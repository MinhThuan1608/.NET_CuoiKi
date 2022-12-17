using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShoesProject.Models;
using System.Collections;
using System.Globalization;
using ShoesProject.Utils;
using System.IO;
using System.Data;
using System.Diagnostics;

namespace ShoesProject.Controllers
{
    [Authorize(Roles = "ADMIN")]
    // Trang web quan ly cac san pham
    public class Admin_ProductController : Controller
    {
        // GET: Admin_Product
        public ActionResult Index()
        {
            ProjectWebBanGiayEntities db = new ProjectWebBanGiayEntities();
            List<sho> listShoes = db.shoes.ToList();    
            return View(listShoes);
        }

        public ActionResult CreateProduct()
        {
            ShoesModel sh = new ShoesModel();
            return View(sh);
        }
        [ValidateInput(false)]
        public ActionResult AddProduct(ShoesModel model, List<HttpPostedFileBase> file, FormCollection collection)
        {
            ProjectWebBanGiayEntities db = new ProjectWebBanGiayEntities();
            sho product = new sho();
            List<option> list = new List<option>();
            // Khi du lieu da nhap vao hop le
            Debug.WriteLine(file.Count);
            if (ModelState.IsValid)
            {
                CreateRandomID cr = new CreateRandomID();
                product.id = cr.newIDProduct();
                product.brand = model.brand;
                product.category = model.category;
                product.checkquality = model.checkquality;
                product.date = DateTime.ParseExact(model.date, "yyyy-MM-dd",
                                       System.Globalization.CultureInfo.InvariantCulture);
                product.depth = model.depth;
                product.description = model.description;
                product.height = model.height;
                product.description = model.description;

                product.manufactory = model.manufactory;
                product.material = model.material;
                product.name = model.name;
                product.price = (double)model.price;
                product.pricebefore = (double)model.pricebefore;
                product.size = model.size;
                product.status = model.status;
                product.weight = model.weight;
                product.width = model.width;
                product.details = model.details;
                Debug.WriteLine(model.details);
                int numoption = int.Parse(model.numoption);
                
                // Save image product
                if (file != null && file.Count>0)
                {
                    string path = "";
                    for (int i= 0;i < file.Count;i++) {
                        Debug.WriteLine("num:" + i);
                        if (i == 0) { 
                            path = Path.Combine(Server.MapPath("~/img"), Path.GetFileName(product.id)+".jpg");
                            product.imageslink = "img/" + product.id + ".jpg";
                        } else {
                            string opid = cr.newIDOption();
                            path = Path.Combine(Server.MapPath("~/img"), Path.GetFileName(opid) + ".jpg");
                            option opt = new option(opid, product.id, collection["coloroption" + i], int.Parse(collection["sizeoption" + i]), double.Parse(collection["priceoption" + i]), int.Parse(collection["quantityoption" + i]), "img/" + opid + ".jpg");
                            product.options.Add(opt);
                            opt.sho = product;
                            list.Add(opt);
                            
                        }
                        
                        file[i].SaveAs(path);
                    }
                }
            }
            foreach (var op in list)
            {
                db.options.Add(op);
            }
            db.shoes.Add(product);
            db.SaveChanges();
            ViewBag.successSave = "Add product successfully!";
            return RedirectToAction("Index");
        }
        public ActionResult ProductInfo(String id)
        {
            ProjectWebBanGiayEntities db = new ProjectWebBanGiayEntities();
            sho product = db.shoes.SingleOrDefault(x => x.id == id);
            List<option> options = db.options.Where(x => x.id_shoe.Equals(id)).ToList();
            System.Diagnostics.Debug.WriteLine("ID san pham dang doc la: " + id);
            ShoesModel result = new ShoesModel();
          
            result.brand = product.brand;
            result.category = product.category;
            result.checkquality = product.checkquality;
            result.date = product.date.ToString("yyyy-MM-dd");
            result.depth = product.depth;
            result.description = product.description;
            result.height = product.height;
            result.imageslink = product.imageslink;
            result.id = product.id;
            result.manufactory = product.manufactory;
            result.material = product.material;
            result.name = product.name;
            result.price = product.price;
            result.pricebefore = product.pricebefore;
            result.rate = product.rate;
            result.size = product.size;
            result.status = product.status;
            result.weight = product.weight;
            result.width = product.width;
            result.details = product.details;

            // Tao dropdown chon trang thai san pham
            List<String> status = new List<string>() {"AVAILABLE","COMING SOON","OUT OF STOCK" };
            
            SelectList statusList = new SelectList(status);
            ViewBag.StatusList = statusList;
            ViewBag.st = status;
            ViewBag.options = options;
            
            return View(result);
        }
        [ValidateInput(false)]
        public ActionResult SaveInfo(ShoesModel model, HttpPostedFileBase file)
        {
            ProjectWebBanGiayEntities db = new ProjectWebBanGiayEntities();
            sho product = db.shoes.SingleOrDefault(x => x.id == model.id);
            
                product.brand=model.brand;
                product.category=model.category;
                product.checkquality=model.checkquality;
                product.date= DateTime.ParseExact(model.date, "yyyy-MM-dd",
                                       System.Globalization.CultureInfo.InvariantCulture);
                product.depth=model.depth;
                product.description=model.description;
                product.height=model.height;
                product.description = model.description;
                product.manufactory=model.manufactory;
                product.material=model.material;
                product.name=model.name;
                product.price= (double)model.price;
                product.pricebefore= (double)model.pricebefore;
                product.size=model.size;
                product.status=model.status;
                product.weight=model.weight;
                product.width=model.width;
                product.details=model.details;

                // Save image product
                if (file != null)
                {
                    string path = Path.Combine(Server.MapPath("~/img"), Path.GetFileName(product.id) + ".jpg");
                    file.SaveAs(path);
                }

                // Save to db
                db.Entry(product).State = EntityState.Modified;
                db.SaveChanges();

                System.Diagnostics.Debug.WriteLine("Luu thanh cong!");

            ViewBag.successSave = "Save info successfully!";

            System.Diagnostics.Debug.WriteLine(model.name);
            System.Diagnostics.Debug.WriteLine(product.name);
            return RedirectToAction("ProductInfo/"+model.id);
            
        }

        public ActionResult DeleteProduct(String id)
        {  
            ProjectWebBanGiayEntities db = new ProjectWebBanGiayEntities();
            sho product = db.shoes.SingleOrDefault(x => x.id == id);
            db.shoes.Remove(product);
            db.SaveChanges();

            return RedirectToAction("Index");
        }
    }

   
}
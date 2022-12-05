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

namespace ShoesProject.Controllers
{
    [Authorize(Roles = "ADMIN")]
    // Trang web quan ly cac san pham
    public class Admin_ProductController : Controller
    {
        // GET: Admin_Product
        public ActionResult Index()
        {
            ProjectWebBanGiayEntities1 db = new ProjectWebBanGiayEntities1();
            List<sho> listShoes = db.shoes.ToList();
            return View(listShoes);
        }

        public ActionResult CreateProduct()
        {
            ShoesModel sh = new ShoesModel();
            return View(sh);
        }
        public ActionResult AddProduct(ShoesModel model, HttpPostedFileBase file)
        {
            ProjectWebBanGiayEntities1 db = new ProjectWebBanGiayEntities1();
            sho product = new sho();
            
            // Khi du lieu da nhap vao hop le
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

                // Save image product
                if (file != null)
                {
                    string path = Path.Combine(Server.MapPath("~/img"), Path.GetFileName(product.id)+".jpg");
                    file.SaveAs(path);
                    product.imageslink = "img/" + product.id + ".jpg";
                }

            }
            else
            {

            }
            db.shoes.Add(product);
            db.SaveChanges();
            ViewBag.successSave = "Add product successfully!";
            return RedirectToAction("Index");
        }
        public ActionResult ProductInfo(String id)
        {
            ProjectWebBanGiayEntities1 db = new ProjectWebBanGiayEntities1();
            sho product = db.shoes.SingleOrDefault(x => x.id == id);
            System.Diagnostics.Debug.WriteLine("ID san pham dang doc la: " + id);
            ShoesModel result = new ShoesModel();
          //  string newDate = DateTime.ParseExact(product.date., "dd/MM/yyyy", CultureInfo.InvariantCulture)
        //.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);

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

            // Tao dropdown chon trang thai san pham
            List<String> status = new List<string>() {"AVAILABLE","COMING SOON","OUT OF STOCK" };
            
            SelectList statusList = new SelectList(status);
            ViewBag.StatusList = statusList;
            ViewBag.st = status;

            return View(result);
        }

        public ActionResult SaveInfo(ShoesModel model, HttpPostedFileBase file)
        {
            ProjectWebBanGiayEntities1 db = new ProjectWebBanGiayEntities1();
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
            ProjectWebBanGiayEntities1 db = new ProjectWebBanGiayEntities1();
            sho product = db.shoes.SingleOrDefault(x => x.id == id);
            db.shoes.Remove(product);
            db.SaveChanges();

            return RedirectToAction("Index");
        }
    }

   
}
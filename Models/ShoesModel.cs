using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ShoesProject.Models
{
    public class ShoesModel
    {
        public string id { get; set; }

        public string name { get; set; }
        public string size { get; set; }
        public string material { get; set; }
        public string color { get; set; }
        public string brand { get; set; }
        public Nullable<double> price { get; set; }
        public String date { get; set; }
        public string manufactory { get; set; }
        public string imageslink { get; set; }
        public Nullable<double> pricebefore { get; set; }
        public string category { get; set; }
        public string width { get; set; }
        public string height { get; set; }
        public string weight { get; set; }
        public string depth { get; set; }
        public string checkquality { get; set; }
        public string description { get; set; }
        public Nullable<int> rate { get; set; }
        public string status { get; set; }


        [DataType(DataType.Upload)]
        [Display(Name = "Upload File")]
        [Required(ErrorMessage = "Please choose file to upload.")]
        public string file { get; set; }
    }
}
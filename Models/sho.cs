//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ShoesProject.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class sho
    {
        public sho()
        {
            this.carts = new HashSet<cart>();
            this.options = new HashSet<option>();
        }
    
        public string id { get; set; }
        public string name { get; set; }
        public string size { get; set; }
        public string material { get; set; }
        public string color { get; set; }
        public string brand { get; set; }
        public double price { get; set; }
        public System.DateTime date { get; set; }
        public string manufactory { get; set; }
        public string imageslink { get; set; }
        public double pricebefore { get; set; }
        public string category { get; set; }
        public string width { get; set; }
        public string height { get; set; }
        public string weight { get; set; }
        public string depth { get; set; }
        public string checkquality { get; set; }
        public string description { get; set; }
        public int rate { get; set; }
        public string status { get; set; }
        public string details { get; set; }
    
        public virtual ICollection<cart> carts { get; set; }
        public virtual ICollection<option> options { get; set; }
    }
}

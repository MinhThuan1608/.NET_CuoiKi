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
    
    public partial class account
    {
        public account()
        {
            this.address_Book = new HashSet<address_Book>();
            this.address_Book1 = new HashSet<address_Book>();
            this.APP_USER = new HashSet<APP_USER>();
            this.APP_USER1 = new HashSet<APP_USER>();
        }
    
        public string username { get; set; }
        public string fullname { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public string address { get; set; }
        public string avatar { get; set; }
        public System.DateTime birthday { get; set; }
    
        public virtual ICollection<address_Book> address_Book { get; set; }
        public virtual ICollection<address_Book> address_Book1 { get; set; }
        public virtual ICollection<APP_USER> APP_USER { get; set; }
        public virtual ICollection<APP_USER> APP_USER1 { get; set; }
    }
}

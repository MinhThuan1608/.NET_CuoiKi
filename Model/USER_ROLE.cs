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
    
    public partial class USER_ROLE
    {
        public long ID { get; set; }
        public long USER_ID { get; set; }
        public long ROLE_ID { get; set; }
    
        public virtual APP_ROLE APP_ROLE { get; set; }
        public virtual APP_ROLE APP_ROLE1 { get; set; }
        public virtual APP_USER APP_USER { get; set; }
        public virtual APP_USER APP_USER1 { get; set; }
    }
}

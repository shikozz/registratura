//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Registy.Base
{
    using System;
    using System.Collections.Generic;
    
    public partial class Users
    {
        public int id { get; set; }
        public string login { get; set; }
        public string password { get; set; }
        public int roleId { get; set; }
        public long personId { get; set; }
    
        public virtual Persons Persons { get; set; }
        public virtual Roles Roles { get; set; }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace eCommerce.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class HECS_User
    {
        public int UserID { get; set; }
        public int UserGroupID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Salt { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Image { get; set; }
        public string Code { get; set; }
        public string IP { get; set; }
        public Nullable<int> Status { get; set; }
        public Nullable<System.DateTime> Date_Added { get; set; }
    }
}
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Restaurant.Models.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class TableDetail
    {
        public int ID { get; set; }
        public Nullable<int> TableID { get; set; }
        public string UserID { get; set; }
        public Nullable<int> EventID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public Nullable<System.TimeSpan> Time { get; set; }
        public string Email { get; set; }
        public string SDT { get; set; }
        public string Messenger { get; set; }
    
        public virtual AspNetUser AspNetUser { get; set; }
        public virtual Event Event { get; set; }
        public virtual Table Table { get; set; }
    }
}

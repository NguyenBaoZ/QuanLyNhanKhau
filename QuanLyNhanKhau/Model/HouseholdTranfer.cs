//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyNhanKhau.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class HouseholdTranfer
    {
        public int TranferId { get; set; }
        public string FromAddress { get; set; }
        public string ToAddress { get; set; }
        public int BookId { get; set; }
        public string Approved { get; set; }
        public string ResolveDescription { get; set; }
        public int ResolveBy { get; set; }
        public string Reason { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
    
        public virtual HouseholdBook HouseholdBook { get; set; }
        public virtual User UResolveBy { get; set; }
    }
}

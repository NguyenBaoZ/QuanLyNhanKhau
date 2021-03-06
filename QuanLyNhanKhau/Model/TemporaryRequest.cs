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
    
    public partial class TemporaryRequest
    {
        public int RequestId { get; set; }
        public int RequestBy { get; set; }
        public string Reason { get; set; }
        public string Approved { get; set; }
        public string ResolveDescription { get; set; }
        public int ResolveBy { get; set; }
        public Nullable<System.DateTime> ExpiredDate { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string RequestType { get; set; }
    
        public virtual CitizenDetail CitizenDetail { get; set; }
        public virtual User UResolveBy { get; set; }
        public virtual User URequestBy { get; set; }
    }
}

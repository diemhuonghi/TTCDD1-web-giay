//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace webbangiay.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class DON_HANG
    {
        public int OrderID { get; set; }
        public Nullable<int> customerID { get; set; }
        public Nullable<System.DateTime> Ngay_dat_hang { get; set; }
        public Nullable<decimal> Tong_tien { get; set; }
        public string Dia_chi { get; set; }
        public string Phuong_thuc_thanh_toan { get; set; }
        public string Ma_theo_doi { get; set; }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace tett.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ChiTietHopDong
    {
        public int SoCTHD { get; set; }
        public int SoHD { get; set; }
        public string MaXe { get; set; }
        public int soLuong { get; set; }
        public decimal TraTruoc { get; set; }
        public Nullable<System.DateTime> NgayNhan { get; set; }
        public Nullable<System.DateTime> NgayTra { get; set; }
        public string GhiChu { get; set; }
    
        public virtual HopDong HopDong { get; set; }
        public virtual Xe Xe { get; set; }
    }
}

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
    
    public partial class XeVao
    {
        public System.DateTime NgayVao { get; set; }
        public string MaXe { get; set; }
        public string GhiChu { get; set; }
        public int MaXeVao { get; set; }
    
        public virtual Xe Xe { get; set; }
    }
}

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
    
    public partial class HopDong
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HopDong()
        {
            this.ThanhToans = new HashSet<ThanhToan>();
        }
    
        public int SoHD { get; set; }
        public Nullable<System.DateTime> Ngay { get; set; }
        public int MaUser { get; set; }
        public string NoiDung { get; set; }
        public Nullable<double> DonGia { get; set; }
        public string HTTT { get; set; }
        public decimal GiaT { get; set; }
        public string DieuKhoan { get; set; }
        public string TinhTrang { get; set; }
    
        public virtual ChiTietHopDong ChiTietHopDong { get; set; }
        public virtual User User { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ThanhToan> ThanhToans { get; set; }
    }
}

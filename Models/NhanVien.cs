
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace WebAPI.Models
{

using System;
    using System.Collections.Generic;
    
public partial class NhanVien
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public NhanVien()
    {

        this.DonNhapNguyenLieux = new HashSet<DonNhapNguyenLieu>();

        this.HoaDons = new HashSet<HoaDon>();

        this.IDs = new HashSet<ID>();

    }


    public int NV_ID { get; set; }

    public string NV_Ten { get; set; }

    public string NV_ChucVu { get; set; }

    public string NV_SDT { get; set; }

    public string NV_DiaChi { get; set; }



    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<DonNhapNguyenLieu> DonNhapNguyenLieux { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<HoaDon> HoaDons { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<ID> IDs { get; set; }

}

}

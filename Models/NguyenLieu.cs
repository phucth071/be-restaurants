
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
    
public partial class NguyenLieu
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public NguyenLieu()
    {

        this.ChiTietDonNhaps = new HashSet<ChiTietDonNhap>();

        this.ChiTietMonAns = new HashSet<ChiTietMonAn>();

    }


    public int NL_ID { get; set; }

    public string NL_Ten { get; set; }

    public string NL_DonViTinh { get; set; }

    public int NL_SoLuong { get; set; }



    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<ChiTietDonNhap> ChiTietDonNhaps { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<ChiTietMonAn> ChiTietMonAns { get; set; }

}

}

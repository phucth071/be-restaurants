
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
    
public partial class BanAn
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public BanAn()
    {

        this.HoaDons = new HashSet<HoaDon>();

    }


    public int Ban_ID { get; set; }

    public string Ban_Ten { get; set; }

    public string Ban_Loai { get; set; }

    public int Ban_SoNguoi { get; set; }

    public string Ban_TrangThai { get; set; }



    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<HoaDon> HoaDons { get; set; }

}

}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Mağza_Ürün_Takip_Sistemi.Models.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblurunler
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblurunler()
        {
            this.tblsatislar = new HashSet<tblsatislar>();
        }
    
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Marka { get; set; }
        public Nullable<short> Stok { get; set; }
        public Nullable<decimal> AlısFiyat { get; set; }
        public Nullable<decimal> SatisFiyat { get; set; }
        public Nullable<int> Kategori { get; set; }
        public Nullable<bool> Durum { get; set; }
        public string Resim { get; set; }
    
        public virtual tblkategori tblkategori { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblsatislar> tblsatislar { get; set; }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SurucuKursuOtomasyonu
{
    using System;
    using System.Collections.Generic;
    
    public partial class Sinav
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Sinav()
        {
            this.KursiyerSinavKayit = new HashSet<KursiyerSinavKayit>();
        }
    
        public int Sinav_ID { get; set; }
        public string Tarihi { get; set; }
        public int SinavTuru_ID { get; set; }
        public string saat { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KursiyerSinavKayit> KursiyerSinavKayit { get; set; }
        public virtual SinavTuru SinavTuru { get; set; }
    }
}

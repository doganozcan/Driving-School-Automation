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
    
    public partial class SurucuBelgesiTuru
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SurucuBelgesiTuru()
        {
            this.KursiyerBelgeKayit = new HashSet<KursiyerBelgeKayit>();
        }
    
        public int SurucuBelgesiT_ID { get; set; }
        public string BelgeSinifi { get; set; }
        public string KullandigiArac { get; set; }
        public string Ucreti { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KursiyerBelgeKayit> KursiyerBelgeKayit { get; set; }
    }
}

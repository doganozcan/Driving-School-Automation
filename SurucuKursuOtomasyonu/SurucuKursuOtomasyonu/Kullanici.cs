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
    
    public partial class Kullanici
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Kullanici()
        {
            this.DireksiyonDersiKayit = new HashSet<DireksiyonDersiKayit>();
            this.KursiyerBelgeKayit = new HashSet<KursiyerBelgeKayit>();
            this.KursiyerOdeme = new HashSet<KursiyerOdeme>();
            this.KursiyerSinavKayit = new HashSet<KursiyerSinavKayit>();
        }
    
        public int Kullanici_ID { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string Kullanici_Adi { get; set; }
        public string Kullanici_Sifre { get; set; }
        public int KullaniciTuru_ID { get; set; }
        public string TC { get; set; }
        public string Adres { get; set; }
        public string Telefon { get; set; }
        public string DogumTarihi { get; set; }
        public string Eposta { get; set; }
        public Nullable<int> maas { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DireksiyonDersiKayit> DireksiyonDersiKayit { get; set; }
        public virtual KullaniciTuru KullaniciTuru { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KursiyerBelgeKayit> KursiyerBelgeKayit { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KursiyerOdeme> KursiyerOdeme { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KursiyerSinavKayit> KursiyerSinavKayit { get; set; }
    }
}

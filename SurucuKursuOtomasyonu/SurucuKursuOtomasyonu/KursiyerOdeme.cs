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
    
    public partial class KursiyerOdeme
    {
        public int KursiyerOdeme_ID { get; set; }
        public int Kursiyer_ID { get; set; }
        public Nullable<int> Tutar { get; set; }
        public string islemTarihi { get; set; }
        public int OdemeTuru_ID { get; set; }
        public int KaydedenKullanici_ID { get; set; }
    
        public virtual Kullanici Kullanici { get; set; }
        public virtual Kursiyer Kursiyer { get; set; }
        public virtual OdemeTuru OdemeTuru { get; set; }
    }
}
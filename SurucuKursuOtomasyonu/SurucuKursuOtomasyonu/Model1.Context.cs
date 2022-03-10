﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class SurucuKursuEntities : DbContext
    {
        public SurucuKursuEntities()
            : base("name=SurucuKursuEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<DireksiyonDersiKayit> DireksiyonDersiKayit { get; set; }
        public virtual DbSet<Donem> Donem { get; set; }
        public virtual DbSet<Kullanici> Kullanici { get; set; }
        public virtual DbSet<KullaniciTuru> KullaniciTuru { get; set; }
        public virtual DbSet<Kursiyer> Kursiyer { get; set; }
        public virtual DbSet<KursiyerBakiye> KursiyerBakiye { get; set; }
        public virtual DbSet<KursiyerBelgeKayit> KursiyerBelgeKayit { get; set; }
        public virtual DbSet<KursiyerOdeme> KursiyerOdeme { get; set; }
        public virtual DbSet<KursiyerSinavKayit> KursiyerSinavKayit { get; set; }
        public virtual DbSet<OdemeTuru> OdemeTuru { get; set; }
        public virtual DbSet<Sinav> Sinav { get; set; }
        public virtual DbSet<SinavTuru> SinavTuru { get; set; }
        public virtual DbSet<SurucuBelgesiTuru> SurucuBelgesiTuru { get; set; }
        public virtual DbSet<SK_Bilgileri> SK_Bilgileri { get; set; }
        public virtual DbSet<Genel_LOG> Genel_LOG { get; set; }
        public virtual DbSet<LOG_Sil> LOG_Sil { get; set; }
        public virtual DbSet<OdemeView> OdemeView { get; set; }
    
        public virtual int OdemeYap(Nullable<int> kursiyer_ID, Nullable<int> tutar, Nullable<int> odemeTuru_ID, Nullable<int> kullanici_ID)
        {
            var kursiyer_IDParameter = kursiyer_ID.HasValue ?
                new ObjectParameter("Kursiyer_ID", kursiyer_ID) :
                new ObjectParameter("Kursiyer_ID", typeof(int));
    
            var tutarParameter = tutar.HasValue ?
                new ObjectParameter("Tutar", tutar) :
                new ObjectParameter("Tutar", typeof(int));
    
            var odemeTuru_IDParameter = odemeTuru_ID.HasValue ?
                new ObjectParameter("OdemeTuru_ID", odemeTuru_ID) :
                new ObjectParameter("OdemeTuru_ID", typeof(int));
    
            var kullanici_IDParameter = kullanici_ID.HasValue ?
                new ObjectParameter("Kullanici_ID", kullanici_ID) :
                new ObjectParameter("Kullanici_ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("OdemeYap", kursiyer_IDParameter, tutarParameter, odemeTuru_IDParameter, kullanici_IDParameter);
        }
    }
}
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SurucuKursuOtomasyonu
{
    public partial class KSinavKayit : Form
    {
        public KSinavKayit()
        {
            InitializeComponent();
        }

        SurucuKursuEntities db = new SurucuKursuEntities();
        public string K_KullaniciID;
        public string K_adiSoyadi;

        public void GENEL_LOG(string message, string stackTrace)
        {
            int id = Convert.ToInt32(K_KullaniciID);
            Genel_LOG log = new Genel_LOG();
            log.ID = id;
            log.Adi_Soyadi = K_adiSoyadi;
            log.islemTarihi = DateTime.Now.ToString("dd.MM.yyyy HH:mm");
            log.Mesaj = message;
            log.StackTrace = stackTrace;

            db.Genel_LOG.Add(log);
            db.SaveChanges();
        }

        private void KSinavKayit_Load(object sender, EventArgs e)
        {
            var kursiyer_load = (from x in db.Kursiyer
                                  select new
                                  {
                                      ID = x.Kursiyer_ID,
                                      x.Adi,
                                      x.Soyadi
                                  }).ToList();
            gridControl1.DataSource = kursiyer_load;

            var sinav_load = (from x in db.Sinav
                              select new
                              {
                                  SınavTürü = x.SinavTuru.SinavTuru1,
                                  x.Tarihi,
                                  x.saat,
                                  x.SinavTuru.Ucreti,
                                  x.Sinav_ID
                              }).ToList();
            gridControl3.DataSource = sinav_load;
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtIDKontrol.Text = gridView1.GetFocusedRowCellValue("ID").ToString();

            var belge_load = (from x in db.KursiyerBelgeKayit.Where(y => y.Kursiyer_ID.ToString() == txtIDKontrol.Text)
                              select new
                              {
                                  x.SurucuBelgesiTuru.BelgeSinifi,
                                  x.Kayıt_Tarih,
                                  x.KBID
                              }).ToList();

            gridControl2.DataSource = belge_load;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            var sinavOdeme = db.KursiyerBakiye.Where(x => x.Kursiyer_ID.ToString() == txtIDKontrol.Text).FirstOrDefault();
            var sinavTutar = db.SinavTuru.Where(y => y.SinavTuru_ID.ToString() == SınavTuruKontrol.Text).FirstOrDefault();
            try
            {
                KursiyerSinavKayit kayit =new KursiyerSinavKayit();
                kayit.Kursiyer_ID = Convert.ToInt32(gridView1.GetFocusedRowCellValue("ID").ToString());
                kayit.Sinav_ID = Convert.ToInt32(gridView3.GetFocusedRowCellValue("Sinav_ID").ToString());
                kayit.Kayitzamani = DateTime.Now.ToString();
                kayit.KaydedenKullanici_ID = Convert.ToInt32(K_KullaniciID);
                kayit.KursiyerBelgeKayit_ID = Convert.ToInt32(gridView2.GetFocusedRowCellValue("KBID").ToString());

                GENEL_LOG("KURSİYER SINAVA KAYDEDİLDİ", "*****");

                if (SınavTuruKontrol.Text=="1")           
                {
                    sinavOdeme.Borc = sinavOdeme.Borc +sinavTutar.Ucreti;
                }
                if(SınavTuruKontrol.Text == "2") { sinavOdeme.Borc = sinavOdeme.Borc + sinavTutar.Ucreti; }


                db.KursiyerSinavKayit.Add(kayit);
                db.SaveChanges();

                var ogrenci = db.Kursiyer.Where(x => x.Kursiyer_ID.ToString() ==txtIDKontrol.Text ).FirstOrDefault();

                XtraMessageBox.Show(ogrenci.Adi + " sınava başarılı şekilde kaydı yapıldı.", "Tamamlandı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception hata)
            {
                GENEL_LOG(hata.Message, hata.StackTrace);
                XtraMessageBox.Show("Hata", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}

        private void gridView3_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (gridView3.GetFocusedRowCellValue("SınavTürü").ToString() == "Yazılı")
            {
                SınavTuruKontrol.Text = "1";
            }
            else SınavTuruKontrol.Text = "2";
           
        }
    }
}

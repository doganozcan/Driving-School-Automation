using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
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
    public partial class Anasayfa : DevExpress.XtraEditors.XtraForm
    {
        public Anasayfa()
        {
            InitializeComponent();
        }
        SurucuKursuEntities db = new SurucuKursuEntities();
        public string K_KullaniciID;
        public string Kullanici_AdSoyad;
        public string K_Turu;
        public string K_TuruID;

        private void Personel_Yetki()
        {
            btnRaporlar.Enabled= btnLoglar.Enabled =btnSinavKayit.Enabled=btnKSinavKayit.Enabled=btnPersonelKayit.Enabled=btnOdemeler.Enabled=btnPersonelBilgileri.Enabled=btnOdemeGiris.Enabled=false;
        }

        public void resimKapa()
        {
            pictureEdit1.Visible = false;
            labelControl1.Visible = false;
            labelControl2.Visible = false;
            labelControl3.Visible = false;

        }

        public void resimAc()
        {
            pictureEdit1.Visible = true;
            labelControl1.Visible = true;
            labelControl2.Visible = true;
            labelControl3.Visible = true;

        }

        public Boolean durum;
        private void Anasayfa_Load(object sender, EventArgs e)
        {
            if (durum == false) resimAc();

            if(K_TuruID !="1") { Personel_Yetki(); }
            
            timer1.Start();
            labelControl2.Text = "Kullanıcı ID: "+K_KullaniciID+"\n"+"Ad Ve Soyad: "+Kullanici_AdSoyad+"\nKullanıcı Türü: "+K_Turu;

            var ayar = db.SK_Bilgileri.Where(x => x.ID == 1).FirstOrDefault();
            labelControl3.Text = ayar.SK_Adi;
        }

        KursiyerKayit frmKursiyer; 
        private void barButtonItem21_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmKursiyer==null || frmKursiyer.IsDisposed) 
            {
                resimKapa();
                frmKursiyer = new KursiyerKayit();
                frmKursiyer.kullaniciID = K_KullaniciID;
                frmKursiyer.K_adSoyad = Kullanici_AdSoyad;

                frmKursiyer.MdiParent = this;
                frmKursiyer.Show();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelControl1.Text = DateTime.Now.ToString();
        }

        private void barButtonItem39_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult dr = XtraMessageBox.Show("Çıkmak İstedğinizden  Emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dr == DialogResult.Yes)
            {
                giris frmGİRİS = new giris();
                frmGİRİS.Show();
                this.Hide();
            }
        }

        Odeme frmOdeme;
        private void barButtonItem23_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmOdeme == null || frmOdeme.IsDisposed)
            {
                resimKapa();
                frmOdeme = new Odeme();
                frmOdeme.K_KullaniciID = K_KullaniciID;
                frmOdeme.K_adSoyad = Kullanici_AdSoyad;
                frmOdeme.MdiParent = this;
                frmOdeme.Show();
            }
           
        }

        SinavKayit frmSinavKayit;
        private void barButtonItem46_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmSinavKayit == null || frmSinavKayit.IsDisposed)
            {
                resimKapa();
                frmSinavKayit = new SinavKayit();
                frmSinavKayit.kullaniciID = K_KullaniciID;
                frmSinavKayit.adSoyad = Kullanici_AdSoyad;

                frmSinavKayit.MdiParent = this;
                frmSinavKayit.Show();
            }
        }

        KSinavKayit frmKsinavkayit;
        private void barButtonItem48_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmKsinavkayit == null || frmKsinavkayit.IsDisposed)
            {
                resimKapa();
                frmKsinavkayit = new KSinavKayit();
                frmKsinavkayit.K_KullaniciID = K_KullaniciID;
                frmKsinavkayit.K_adiSoyadi = Kullanici_AdSoyad;

                frmKsinavkayit.MdiParent = this;
                frmKsinavkayit.Show();
            }
        }

        Personel frmPersonel;
        private void barButtonItem25_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmPersonel == null || frmPersonel.IsDisposed)
            {
                resimKapa();
                frmPersonel = new Personel();
                frmPersonel.kullaniciID = K_KullaniciID;
                frmPersonel.K_adiSoyad = Kullanici_AdSoyad;

                frmPersonel.MdiParent = this;
                frmPersonel.Show();
            }      
        }

        AdayBilgileri frmAdayBilgileri;
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmAdayBilgileri == null || frmAdayBilgileri.IsDisposed)
            {
                resimKapa();
                frmAdayBilgileri = new AdayBilgileri();
                frmAdayBilgileri.SilenKİSİ = Kullanici_AdSoyad;
                frmAdayBilgileri.kullaniciID = K_KullaniciID;

                frmAdayBilgileri.MdiParent = this;
                frmAdayBilgileri.Show();
            }
        }

        OdemeBilgileri frmOdemeBilgileri;
        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmOdemeBilgileri == null || frmOdemeBilgileri.IsDisposed)
            {
                resimKapa();
                frmOdemeBilgileri = new OdemeBilgileri();
                frmOdemeBilgileri.kullaniciID = K_KullaniciID;
                frmOdemeBilgileri.K_adSoyad = Kullanici_AdSoyad;

                frmOdemeBilgileri.MdiParent = this;
                frmOdemeBilgileri.Show();
            }
        }

        PersonelBilgileri frmPersonelBilgileri;
        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmPersonelBilgileri == null || frmPersonelBilgileri.IsDisposed)
            {
                resimKapa();
                frmPersonelBilgileri = new PersonelBilgileri();
                frmPersonelBilgileri.kullaniciID = K_KullaniciID;
                frmPersonelBilgileri.SilenKİSİ = Kullanici_AdSoyad;

                frmPersonelBilgileri.MdiParent = this;
                frmPersonelBilgileri.Show();
            }

        }

        private void barButtonItem18_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Application.Exit();
        }

       

        Ayarlar frmAyarlar;
        private void barButtonItem19_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            if (frmAyarlar == null || frmAyarlar.IsDisposed)
            {
                resimKapa();
                frmAyarlar = new Ayarlar();
                frmAyarlar.K_KullaniciID = K_KullaniciID;
                frmAyarlar.K_adiSoyadi = Kullanici_AdSoyad;

                resimKapa();
                frmAyarlar.MdiParent = this;
                frmAyarlar.Show();
            }
        }

        KSinavBilgileri frmKBilgi;
        private void barButtonItem50_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmKBilgi == null || frmKBilgi.IsDisposed)
            {
                resimKapa();
                frmKBilgi = new KSinavBilgileri();
                frmKBilgi.kullaniciID = K_KullaniciID;
                frmKBilgi.SilenKİSİ = Kullanici_AdSoyad;

                frmKBilgi.MdiParent = this;
                frmKBilgi.Show();
            }
        }

        private void barButtonItem52_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            resimKapa();
            KursiyerRapor rapor = new KursiyerRapor();
            ReportPrintTool rpt = new ReportPrintTool(rapor);
            rpt.ShowRibbonPreviewDialog();
        }

        private void Anasayfa_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult giriskapanis = XtraMessageBox.Show("Programı kapatmak istediğinizden eminmisiniz ? ", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (giriskapanis == DialogResult.No)
            {
                e.Cancel = true;
                return;
            }
            Environment.Exit(0);
        }

        private void barButtonItem53_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            resimKapa();
            PersonelRapor rapor = new PersonelRapor();
            ReportPrintTool rpt = new ReportPrintTool(rapor);
            rpt.ShowRibbonPreviewDialog();

        }

        GenelRapor frmGenelR;
        private void barButtonItem13_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //if (frmGenelR == null || frmGenelR.IsDisposed)
            //{
                resimKapa();
                frmGenelR = new GenelRapor();
                frmGenelR.ShowDialog();
            //}
        }

        private void barButtonItem54_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            resimKapa();
            OdemeRapor rapor = new OdemeRapor();
            ReportPrintTool rpt = new ReportPrintTool(rapor);
            rpt.ShowRibbonPreviewDialog();
        }

        private void barButtonItem56_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            resimKapa();
            GenelLog rapor = new GenelLog();
            ReportPrintTool rpt = new ReportPrintTool(rapor);
            rpt.ShowRibbonPreviewDialog();
        }

        private void barButtonItem57_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            resimKapa();
            SilmeLog rapor = new SilmeLog();
            ReportPrintTool rpt = new ReportPrintTool(rapor);
            rpt.ShowRibbonPreviewDialog();
        }

        DireksiyonDersi frmDireksiyon;
        private void barButtonItem1_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmDireksiyon == null || frmDireksiyon.IsDisposed)
            {
                resimKapa();
                frmDireksiyon = new DireksiyonDersi();
                frmDireksiyon.Kullanici_ID = Convert.ToInt32(K_KullaniciID);
                frmDireksiyon.K_adiSoyadi = Kullanici_AdSoyad;

                frmDireksiyon.MdiParent = this;
                frmDireksiyon.Show();
            }
        }

        DireksiyonDersiBilgileri frmDireksiyonBilgi;
        private void btnDireksiyonBilgi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmDireksiyonBilgi == null || frmDireksiyonBilgi.IsDisposed)
            {
                resimKapa();
                frmDireksiyonBilgi = new DireksiyonDersiBilgileri();
                frmDireksiyonBilgi.kullaniciID = K_KullaniciID.ToString();
                frmDireksiyonBilgi.SilenKİSİ = Kullanici_AdSoyad;

                frmDireksiyonBilgi.MdiParent = this;
                frmDireksiyonBilgi.Show();
            }
        }
    }
}

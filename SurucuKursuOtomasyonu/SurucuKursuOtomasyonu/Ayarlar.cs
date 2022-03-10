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
    public partial class Ayarlar : DevExpress.XtraEditors.XtraForm
    {
        public Ayarlar()
        {
            InitializeComponent();
        }
        SurucuKursuEntities db = new SurucuKursuEntities();
        public string K_KullaniciID;
        public string K_adiSoyadi;
        public string Kullanici_TuruID;

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

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Kullanici personel = db.Kullanici.Where(x => x.Kullanici_ID.ToString() == K_KullaniciID).FirstOrDefault();
            try
            {
                if (txtMevcutSifre.Text == "" || txtYeniSifre.Text == "" || txtSifreTekrar.Text == "")
                {
                    XtraMessageBox.Show("BOŞ ALAN BIRAKMAYIN", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    if (txtMevcutSifre.Text == personel.Kullanici_Sifre)
                    {
                        if (txtYeniSifre.Text == txtSifreTekrar.Text)
                        {
                            personel.Kullanici_Sifre = txtYeniSifre.Text;

                            GENEL_LOG("ŞİFRE GÜNCELLENDİ", "******");

                            db.SaveChanges();

                            txtMevcutSifre.Text = ""; txtYeniSifre.Text = ""; txtSifreTekrar.Text = "";
                            XtraMessageBox.Show("Şifre başarılı şekilde değiştirildi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            XtraMessageBox.Show("Yeni şifre ve tekrarı uyuşmuyor", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    else XtraMessageBox.Show("MEVCUT ŞİFRE YANLIŞ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception hata)
            {
                GENEL_LOG(hata.Message, hata.StackTrace);
                XtraMessageBox.Show("HATA", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            try
            {
                var ayarlar = db.SK_Bilgileri.Where(x => x.ID == 1).FirstOrDefault();

                ayarlar.SK_Adi = txtSKAdi.Text;
                ayarlar.SK_Adress = txtSKAdres.Text;
                ayarlar.SK_Telefon = txtSKTelefon.Text;

                GENEL_LOG("AYARLAR GÜNCELLENDİ", "*******");
                db.SaveChanges();
                txtSKAdres.Text = ""; txtSKAdi.Text = ""; txtSKTelefon.Text = "";

                labelControl7.Text = ayarlar.SK_Adi;

                txtSKAdi.Text = ayarlar.SK_Adi;
                txtSKAdres.Text = ayarlar.SK_Adress;
                txtSKTelefon.Text = ayarlar.SK_Telefon;
                XtraMessageBox.Show("Başarılı şekilde güncellendi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception hata1)
            {
                GENEL_LOG(hata1.Message, hata1.StackTrace);
                XtraMessageBox.Show("HATA", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void pictureEdit1_Click(object sender, EventArgs e)
        {
            txtMevcutSifre.Properties.UseSystemPasswordChar = false;
        }

        private void pictureEdit1_DoubleClick(object sender, EventArgs e)
        {
            txtMevcutSifre.Properties.UseSystemPasswordChar = true;
        }

        private void Ayarlar_Load(object sender, EventArgs e)
        {
            if (K_KullaniciID != "1")
            {
                panelControl1.Enabled = false;
                lbKontrol.Visible = true;
            }
            var ayarlar = db.SK_Bilgileri.Where(x => x.ID == 1).FirstOrDefault();
            labelControl7.Text = ayarlar.SK_Adi;

            txtSKAdi.Text = ayarlar.SK_Adi;
            txtSKAdres.Text = ayarlar.SK_Adress;
            txtSKTelefon.Text = ayarlar.SK_Telefon;
        }
    }
}

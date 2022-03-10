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
    public partial class KursiyerKayit : DevExpress.XtraEditors.XtraForm
    {
        public KursiyerKayit()
        {
            InitializeComponent();
        }

        SurucuKursuEntities db = new SurucuKursuEntities();
        public string K_adSoyad;
        public string kullaniciID;

        public void GENEL_LOG(string message, string stackTrace)
        {
            int id = Convert.ToInt32(kullaniciID);
            Genel_LOG log = new Genel_LOG();
            log.ID = id;
            log.Adi_Soyadi = K_adSoyad;
            log.islemTarihi = DateTime.Now.ToString("dd.MM.yyyy HH:mm");
            log.Mesaj = message;
            log.StackTrace = stackTrace;

            db.Genel_LOG.Add(log);
            db.SaveChanges();
        }


        private void Temizle()
        {
            txtAdi.Text = ""; txtSoyadi.Text = ""; txtTc.Text = ""; cbxOgrenimdurum.Text = ""; txtAdres.Text = ""; txtKayitTarihi.Text = ""; txtTelefon.Text = ""; txtDogumTarihi.Text = "";

            if (SaglikVar.Checked || Saglikyok.Checked == true)
            {
                Saglikyok.Checked = false;
                SaglikVar.Checked = false;
            }

            if (AdliVar.Checked || AdliYok.Checked == true)
            {
                AdliYok.Checked = false;
                AdliVar.Checked = false;
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtAdi.Text == "" || txtSoyadi.Text == "" || txtTc.Text == "" || txtAdres.Text == "" || cbxOgrenimdurum.Text == "" || txtKayitTarihi.Text == "" || txtTelefon.Text == "" || txtDogumTarihi.Text == "")
                {
                    XtraMessageBox.Show("BOŞ ALANLARI DOLDURUN", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    Kursiyer eskiKursiyer = db.Kursiyer.Where(x => x.TC == txtTc.Text).FirstOrDefault();
                    if (eskiKursiyer != null)
                    {
                        XtraMessageBox.Show("Bu T.C numarasına sahip aday kayıtlı", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        Kursiyer aday = new Kursiyer();
                        aday.Adi = txtAdi.Text;
                        aday.Soyadi = txtSoyadi.Text;
                        aday.TC = txtTc.Text;
                        aday.Adres = txtAdres.Text;
                        aday.OgrenimDurumu = cbxOgrenimdurum.Text;
                        aday.AdliBelge = Convert.ToBoolean(AdliBelgeKontrol.Text);
                        aday.KayitTarihi = txtKayitTarihi.Text;
                        aday.Telefon = txtTelefon.Text;
                        aday.DogumTarih = txtDogumTarihi.Text;
                        aday.SaglikRaporu = Convert.ToBoolean(SaglikRaporuKontrol.Text);

                        GENEL_LOG("KURSİYER KAYDEDİLDİ", "*****");

                        db.Kursiyer.Add(aday);
                        db.SaveChanges();
                        Temizle();
                        XtraMessageBox.Show("Kayıt başarılı şekilde yapıldı.", "Tamamlandı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception hata)
            {
                GENEL_LOG(hata.Message, hata.StackTrace);
                XtraMessageBox.Show("Lütfen bilgileri doğru giriniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void pictureEdit1_MouseEnter(object sender, EventArgs e)
        {
            simpleButton1.Enabled = true;
        }

        private void KursiyerKayit_Load(object sender, EventArgs e)
        {
           
        }

        private void AdliVar_CheckedChanged(object sender, EventArgs e)
        {
           AdliBelgeKontrol.Text = "True";
            if (AdliVar.Checked == true)
            {
                AdliYok.Enabled = false;
            }

            if (AdliVar.Checked == false)
            {
                AdliYok.Enabled = true;
            }
        }

        private void AdliYok_CheckedChanged(object sender, EventArgs e)
        {
            AdliBelgeKontrol.Text = "False";
            if (AdliYok.Checked == true)
            {
                AdliVar.Enabled = false;
            }

            if (AdliYok.Checked == false)
            {
                AdliVar.Enabled = true;
            }
        }

        private void SaglikVar_CheckedChanged(object sender, EventArgs e)
        {
            SaglikRaporuKontrol.Text = "True";

            if (SaglikVar.Checked == true)
            {
                Saglikyok.Enabled = false;
            }

            if (SaglikVar.Checked == false)
            {
                Saglikyok.Enabled = true;
            }
        }

        private void Saglikyok_CheckedChanged(object sender, EventArgs e)
        {
            SaglikRaporuKontrol.Text = "False";

            if (Saglikyok.Checked == true)
            {
                SaglikVar.Enabled = false;
            }

            if (Saglikyok.Checked == false)
            {
                SaglikVar.Enabled = true;
            }
        }

        private void KursiyerKayit_FormClosed(object sender, FormClosedEventArgs e)
        {
            Anasayfa frm = new Anasayfa();
            frm.durum = false;
            
        }
    }
}

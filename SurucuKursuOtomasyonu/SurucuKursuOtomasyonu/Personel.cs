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
    public partial class Personel : Form
    {
        public Personel()
        {
            InitializeComponent();
        }
        SurucuKursuEntities db = new SurucuKursuEntities();
        public string K_adiSoyad;
        public string kullaniciID;

        public void GENEL_LOG(string message, string stackTrace)
        {
            int id = Convert.ToInt32(kullaniciID);
            Genel_LOG log = new Genel_LOG();
            log.ID = id;
            log.Adi_Soyadi = K_adiSoyad;
            log.islemTarihi = DateTime.Now.ToString("dd.MM.yyyy HH:mm");
            log.Mesaj = message;
            log.StackTrace = stackTrace;

            db.Genel_LOG.Add(log);
            db.SaveChanges();
        }
        private void Temizle()
        {
            txtAdi.Text = ""; txtSoyadi.Text = "";
            txtTc.Text = ""; txtAdres.Text = ""; txtTelefon.Text = ""; txtDogumTarihi.Text = "";
            txtEposta.Text = ""; txtKullaniciAdi.Text = ""; txtSifre.Text = ""; txtMaas.Text = "";
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtAdi.Text == "" || txtSoyadi.Text == "" || txtTc.Text == "" || txtAdres.Text == "" || txtTelefon.Text == "" || txtDogumTarihi.Text == "" || txtEposta.Text == "" || txtKullaniciAdi.Text == "" || txtSifre.Text == "")
                {
                    XtraMessageBox.Show("BOŞ ALANLARI DOLDURUN", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    Kullanici eskiK = db.Kullanici.Where(x => x.TC == txtTc.Text).FirstOrDefault();
                    if(eskiK != null)
                    {
                        XtraMessageBox.Show("Bu T.C numarasına sahip personel kayıtlı", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        Kullanici personel = new Kullanici();
                        personel.Adi = txtAdi.Text;
                        personel.Soyadi = txtSoyadi.Text;
                        personel.Kullanici_Adi = txtKullaniciAdi.Text;
                        personel.Kullanici_Sifre = txtSifre.Text;
                        personel.KullaniciTuru_ID = Convert.ToInt32(labelControl9.Text);
                        personel.TC = txtTc.Text;
                        personel.Adres = txtAdres.Text;
                        personel.Telefon = txtTelefon.Text;
                        personel.DogumTarihi = txtDogumTarihi.Text;
                        personel.Eposta = txtEposta.Text;
                        personel.maas = Convert.ToInt32(txtMaas.Text);

                        GENEL_LOG("PERSONEL KAYDEDİLDİ", "******");

                        db.Kullanici.Add(personel);
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

        private void Personel_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtAdi;
            var gorevi = (from x in db.KullaniciTuru
                          select new
                          {
                              ID=x.KullaniciTuru_ID,
                              x.Turu
                          }).ToList();
            cbGorev.Properties.DisplayMember = "Turu";
            cbGorev.Properties.ValueMember = "ID";
            cbGorev.Properties.DataSource = gorevi;
        }

        private void cbGorev_EditValueChanged(object sender, EventArgs e)
        {
            //labelControl9.Text = cbGorev.Text;
            KullaniciTuru q = db.KullaniciTuru.Where(x => x.Turu == cbGorev.Text).FirstOrDefault();
            labelControl9.Text = q.KullaniciTuru_ID.ToString();
        }

        private void pictureEdit1_Click(object sender, EventArgs e)
        {
            txtSifre.Properties.UseSystemPasswordChar = false;
        }

        private void pictureEdit1_DoubleClick(object sender, EventArgs e)
        {
            txtSifre.Properties.UseSystemPasswordChar = true;
        }
    }
}

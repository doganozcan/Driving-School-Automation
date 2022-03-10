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
    public partial class giris : DevExpress.XtraEditors.XtraForm
    {
        public giris()
        {
            InitializeComponent();
        }

        SurucuKursuEntities db = new SurucuKursuEntities();
        public string K_KullaniciID;

        private void giris_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtKullaniciAdi;

            labelControl1.Parent = pictureEdit1;
            labelControl1.BackColor = Color.Transparent;

            labelControl2.Parent = pictureEdit1;
            labelControl2.BackColor = Color.Transparent;

            labelControl3.Parent = pictureEdit1;
            labelControl3.BackColor = Color.Transparent;

             labelControl4.Parent = pictureEdit1;
             labelControl4.BackColor = Color.Transparent;

            labelControl5.Parent = pictureEdit1;
            labelControl5.BackColor = Color.Transparent;

            labelControl6.Parent = pictureEdit1;
            labelControl6.BackColor = Color.Transparent;
        }

        
        public void LOG_BGiris(int ID,string AdSoyad,string islemtarihi,string message,string stackTrace)
        {
            Genel_LOG log = new Genel_LOG();
            log.ID = ID;
            log.Adi_Soyadi =AdSoyad;
            log.islemTarihi = islemtarihi;
            log.Mesaj = message;
            log.StackTrace = stackTrace;

            db.Genel_LOG.Add(log);
            db.SaveChanges();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            Kullanici girisYapan = db.Kullanici.Where(x => x.Kullanici_Adi == txtKullaniciAdi.Text && x.Kullanici_Sifre == txtSifre.Text).FirstOrDefault();
            if(txtKullaniciAdi.Text !=null && txtSifre.Text !=null && girisYapan !=null)
            {
                K_KullaniciID = girisYapan.Kullanici_ID.ToString();
                Anasayfa frm = new Anasayfa(); Ayarlar frmAyarlar = new Ayarlar();
                string adıSoyadı= girisYapan.Adi + " " + girisYapan.Soyadi;
                string tarih = DateTime.Now.ToString("dd.MM.yyyy HH:mm");

                frm.K_KullaniciID = girisYapan.Kullanici_ID.ToString();
                frm.Kullanici_AdSoyad = adıSoyadı;
         
                KullaniciTuru kturu = db.KullaniciTuru.Where(y => y.KullaniciTuru_ID == girisYapan.KullaniciTuru_ID).FirstOrDefault();
                frm.K_Turu = kturu.Turu;
                frmAyarlar.Kullanici_TuruID = kturu.KullaniciTuru_ID.ToString();
                frm.K_TuruID = kturu.KullaniciTuru_ID.ToString();

               LOG_BGiris(girisYapan.Kullanici_ID, adıSoyadı, tarih, "Giriş Yapıldı", "**********");

                frm.Show();
                this.Hide();
            }
            else
            {
                string tarih = DateTime.Now.ToString("dd.MM.yyyy HH:mm");
                XtraMessageBox.Show("Kullanıcı adı veya şifre hatalı bilgilerinizi kontrol edip tekrar girin", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                LOG_BGiris(0,txtKullaniciAdi.Text, tarih, "Giriş Yapılamadı", "**********");
            }
        }



        private void labelControl3_Click(object sender, EventArgs e)
        {
            txtKullaniciAdi.Text = ""; txtSifre.Text = "";
            txtKullaniciAdi.Focus();
        }

        private void labelControl2_Click(object sender, EventArgs e)
        {
            
            Application.Exit();
        }

        private void labelControl6_Click(object sender, EventArgs e)
        {
            sifremiUnuttum frm = new sifremiUnuttum();
            frm.ShowDialog();
        }

        private void pictureEdit2_Click(object sender, EventArgs e)
        {
            txtSifre.Properties.UseSystemPasswordChar = false;
        }

        private void pictureEdit2_DoubleClick(object sender, EventArgs e)
        {
            txtSifre.Properties.UseSystemPasswordChar = true;
        }
    }
}

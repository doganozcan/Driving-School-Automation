using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security;
using System.Net.Mail;
using System.Net;
using DevExpress.XtraEditors;

namespace SurucuKursuOtomasyonu
{
    public partial class sifremiUnuttum : DevExpress.XtraEditors.XtraForm
    {
        public sifremiUnuttum()
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

        private void sifremiUnuttum_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtTc;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Kullanici girisYapan = db.Kullanici.Where(x => x.Eposta == txtMail.Text && x.TC == txtTc.Text).FirstOrDefault();

            

            if(girisYapan !=null && txtMail.Text !=null && txtTc !=null)
            {
                labelControl2.Visible = true;
                labelControl2.Text = "Girmiş Olduğunuz Bilgiler Uyuşuyor Şifreniz Mail Olarak Gönderildi";
                labelControl2.ForeColor = Color.Green;

                SmtpClient smtpserver = new SmtpClient();
                MailMessage mail = new MailMessage();
                string tarih = DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToLongTimeString();
                string mailadresim = "ozcanyazilim34@gmail.com";
                string sifre = "Ozcanyazilim34.";
                string smptsrvr = "smtp.gmail.com";
                string kime = girisYapan.Eposta;
                string konu = "Şifre hatırlatma talebi";
                string yaz = "Sayın " + girisYapan.Adi + " " + girisYapan.Soyadi + " bizden " + tarih + " tarihinde şifre hatırlatma talebinde bulundunuz\nParolanız: " + girisYapan.Kullanici_Sifre + "\niyi günler";
                smtpserver.Credentials = new NetworkCredential(mailadresim, sifre);
                smtpserver.Port = 587;
                smtpserver.Host = smptsrvr;
                smtpserver.EnableSsl = true;
                mail.From = new MailAddress(mailadresim);
                mail.To.Add(kime);
                mail.Subject = konu;
                mail.Body = yaz;smtpserver.Send(mail);

                GENEL_LOG("ŞİFRE HATIRLATMA GÖNDERİLDİ","*******");

               XtraMessageBox.Show("ŞİFRE HATIRLATMA BAŞARILI ŞEKİLDE GÖNDERİLDİ", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }
            else
            {
                labelControl2.Visible = true;
                labelControl2.Text = "Girmiş Olduğunuz Bilgiler Uyuşmuyor";
                labelControl2.ForeColor = Color.Red;
                GENEL_LOG("ŞİFRE HATIRLATMA GÖNDERİLEMEDİ", "******");
                XtraMessageBox.Show("ŞİFRE HATIRLATMA YAPILAMADI","UYARI",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                txtTc.Focus();
            }

        }
    }
}

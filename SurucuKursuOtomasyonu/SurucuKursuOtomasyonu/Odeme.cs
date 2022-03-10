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
    public partial class Odeme : DevExpress.XtraEditors.XtraForm
    {
        public Odeme()
        {
            InitializeComponent();
        }

        SurucuKursuEntities db = new SurucuKursuEntities();
        public string K_KullaniciID;
        public string K_adSoyad;
        
        public void GENEL_LOG(string message, string stackTrace)
        {
            int id = Convert.ToInt32(K_KullaniciID);
            Genel_LOG log = new Genel_LOG();
            log.ID = id;
            log.Adi_Soyadi = K_adSoyad;
            log.islemTarihi = DateTime.Now.ToString("dd.MM.yyyy HH:mm");
            log.Mesaj = message;
            log.StackTrace = stackTrace;

            db.Genel_LOG.Add(log);
            db.SaveChanges();
        }

        private void Odeme_Load(object sender, EventArgs e)
        {
            var bilgiler = (from x in db.Kursiyer
                            select new
                            {
                                ID = x.Kursiyer_ID,
                                x.TC,
                                ADI = x.Adi,
                                SOYADI = x.Soyadi
                            }).ToList();
            gridControl1.DataSource = bilgiler;

            var EhliyetTuru = (from x in db.SurucuBelgesiTuru
                               select new
                               {
                                   ID=x.SurucuBelgesiT_ID,
                                   x.BelgeSinifi
                               }).ToList();

            cbEhliyetSinifi.Properties.DisplayMember = "BelgeSinifi";
            cbEhliyetSinifi.Properties.ValueMember = "ID";
            cbEhliyetSinifi.Properties.DataSource = EhliyetTuru;
           
            var donem = (from x in db.Donem
                               select new
                               {
                                   ID = x.Donem_ID,
                                   donemTarihi=x.Ay+"-"+x.Yil
                               }).ToList();

            cbxDonem.Properties.DisplayMember = "donemTarihi";
            cbxDonem.Properties.ValueMember = "ID";
            cbxDonem.Properties.DataSource = donem;


            var odemeTuru = (from x in db.OdemeTuru
                         select new
                         {
                             ID = x.OdemeTuru_ID,
                             Türü=x.Turu
                         }).ToList();

            cbOdemeTuru.Properties.DisplayMember = "Türü";
            cbOdemeTuru.Properties.ValueMember = "ID";
            cbOdemeTuru.Properties.DataSource = odemeTuru;

        }

        
        private void cbEhliyetSinifi_EditValueChanged(object sender, EventArgs e)
        {
            var odenecekMiktar = (from x in db.SurucuBelgesiTuru.Where(x=>x.BelgeSinifi == cbEhliyetSinifi.Text)
                                select new
                                {
                                    ID = x.SurucuBelgesiT_ID,
                                    x.Ucreti
                                }).ToList();

           txtOdenecekMiktar.Properties.DisplayMember = "Ucreti";
           txtOdenecekMiktar.Properties.ValueMember = "ID";
           txtOdenecekMiktar.Properties.DataSource = odenecekMiktar;

            SurucuBelgesiTuru q = db.SurucuBelgesiTuru.Where(x => x.BelgeSinifi == cbEhliyetSinifi.Text).FirstOrDefault();
            labelControl4.Text = q.SurucuBelgesiT_ID.ToString();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtID.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            txtAdSoyad.Text = gridView1.GetFocusedRowCellValue("ADI").ToString()+" "+gridView1.GetFocusedRowCellValue("SOYADI").ToString();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtID.Text == "" || txtAdSoyad.Text == "" || txtOdemeTutar.Text == "" || txtOdenecekMiktar.Text == "" || cbxDonem.Text == "" || cbOdemeTuru.Text == "" || txtOdemeTutar.Text == "" || tarih.Text == "")
                {
                    XtraMessageBox.Show("BOŞ ALANLARI DOLDURUN", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    KursiyerOdeme aday = new KursiyerOdeme();
                    aday.Kursiyer_ID = Convert.ToInt32(txtID.Text);
                    aday.Tutar = Convert.ToInt32(txtOdemeTutar.Text);
                    aday.islemTarihi = tarih.Text;
                    aday.OdemeTuru_ID = Convert.ToInt32(labelControl3.Text);
                    aday.KaydedenKullanici_ID = Convert.ToInt32(K_KullaniciID);

                    KursiyerBakiye kBakiye = new KursiyerBakiye();
                    kBakiye.Borc = Convert.ToInt32(txtOdenecekMiktar.Text);
                    kBakiye.Odenen = Convert.ToInt32(txtOdemeTutar.Text);
                    kBakiye.Kursiyer_ID = Convert.ToInt32(txtID.Text);

                    KursiyerBelgeKayit belge = new KursiyerBelgeKayit();
                    belge.Kursiyer_ID = Convert.ToInt32(txtID.Text);
                    belge.SurucuBelgesi_ID = Convert.ToInt32(labelControl4.Text);
                    belge.Kayıt_Tarih = tarih.Text;
                    belge.Donem_ID = Convert.ToInt32(labelControl5.Text);
                    belge.KaydedenKullanici_ID = Convert.ToInt32(K_KullaniciID);

                    GENEL_LOG("KURSİYER ÖDEME ALINDI", "********");

                   

                    db.KursiyerOdeme.Add(aday);
                    db.KursiyerBakiye.Add(kBakiye);
                    db.KursiyerBelgeKayit.Add(belge);
                    db.SaveChanges();

                    tarih.Text = ""; txtOdemeTutar.Text = "";
                    XtraMessageBox.Show("Kayıt başarılı şekilde yapıldı.", "Tamamlandı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception hata)
            {
                GENEL_LOG(hata.Message, hata.StackTrace);

                XtraMessageBox.Show("Lütfen bilgileri doğru giriniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void cbOdemeTuru_EditValueChanged(object sender, EventArgs e)
        {
            if (cbOdemeTuru.Text == "Sınav")
            { MessageBox.Show("Sınav ödemesini kursiyer sınav kayıt alanından yapın!"); } //labelControl3.Text = "1";
            else if (cbOdemeTuru.Text == "Ehliyet Borcu") labelControl3.Text = "2";
        }

        private void cbxDonem_EditValueChanged(object sender, EventArgs e)
        {
            Donem q = db.Donem.Where(x => x.Ay+"-"+x.Yil == cbxDonem.Text).FirstOrDefault();
            labelControl5.Text = q.Donem_ID.ToString();
        }
    }
}

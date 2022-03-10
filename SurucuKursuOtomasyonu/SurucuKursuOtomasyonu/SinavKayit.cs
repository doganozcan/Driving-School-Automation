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
    public partial class SinavKayit : Form
    {
        public SinavKayit()
        {
            InitializeComponent();
        }

        SurucuKursuEntities db = new SurucuKursuEntities();
        public string kullaniciID;
        public string adSoyad;
        public void GENEL_LOG(string message, string stackTrace)
        {
            int id = Convert.ToInt32(kullaniciID);
            Genel_LOG log = new Genel_LOG();
            log.ID = id;
            log.Adi_Soyadi = adSoyad;
            log.islemTarihi = DateTime.Now.ToString("dd.MM.yyyy HH:mm");
            log.Mesaj = message;
            log.StackTrace = stackTrace;

            db.Genel_LOG.Add(log);
            db.SaveChanges();
        }

        public void Listele()
        {
            var sinav = (from x in db.Sinav
                         select new
                         {
                             IDSinav=x.Sinav_ID,
                             SınavTuru=x.SinavTuru.SinavTuru1,
                             x.Tarihi,
                             x.saat
                         }).ToList();
            gridControl1.DataSource = sinav;
        }

        public void Temizle()
        {
            cbSinavTuru.Text = ""; txtSinavTarihi.Text = ""; cbSinavSaati.Text = ""; 
        }


        private void SinavKayit_Load(object sender, EventArgs e)
        {
            Listele();
            var sinav = (from x in db.SinavTuru
                         select new
                         {
                             ID = x.SinavTuru_ID,
                             SınavTürü = x.SinavTuru1
                         }).ToList();

            cbSinavTuru.Properties.DisplayMember = "SınavTürü";
            cbSinavTuru.Properties.ValueMember = "ID";
            cbSinavTuru.Properties.DataSource = sinav;

            cbSinavSaati.SelectedIndex = 0;

        }


        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSinavTarihi.Text == "" || cbSinavSaati.Text == "" || cbSinavTuru.Text == "")
                {
                    XtraMessageBox.Show("BOŞ ALANLARI DOLDURUN", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    Sinav tbl_sinav = new Sinav();
                    tbl_sinav.Tarihi = txtSinavTarihi.Text;
                    tbl_sinav.SinavTuru_ID = Convert.ToInt32(labelControl2.Text);
                    tbl_sinav.saat = cbSinavSaati.Text;

                    db.Sinav.Add(tbl_sinav);
                    db.SaveChanges();
                    Listele();
                    Temizle();
                    XtraMessageBox.Show("Kayıt başarılı şekilde yapıldı.", "Tamamlandı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
               
                XtraMessageBox.Show("Lütfen bilgileri doğru giriniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

       

        
        private void cbSinavTuru_EditValueChanged(object sender, EventArgs e)
        {
            if(cbSinavTuru.Text=="Yazılı")
            {
                labelControl2.Text = "1";
            }
            else if(cbSinavTuru.Text == "Direksiyon")
            {  
                labelControl2.Text = "2";
            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            labelControl4.Text = gridView1.GetFocusedRowCellValue("IDSinav").ToString();
            //cbSinavTuru.Text = gridView1.GetFocusedRowCellValue("SınavTuru").ToString();
            txtSinavTarihi.Text = gridView1.GetFocusedRowCellValue("Tarihi").ToString();
            cbSinavSaati.Text = gridView1.GetFocusedRowCellValue("saat").ToString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            var sinavSil = db.Sinav.Where(x => x.Sinav_ID.ToString() == labelControl4.Text).FirstOrDefault();
            try
            {
                DialogResult dr = XtraMessageBox.Show(sinavSil.Tarihi+" Tarihli sinavi silmek istedğinizden  emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dr == DialogResult.Yes)
                {
                    GENEL_LOG("SINAV SİSTEME KAYDEDİLDİ", "********");
                    db.Sinav.Remove(sinavSil);
                    db.SaveChanges();

                    Listele();
                    Temizle();
                    XtraMessageBox.Show("KAYIT SİLİNDİ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception hata)
            {
                GENEL_LOG(hata.Message, hata.StackTrace);
                XtraMessageBox.Show("HATA", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                var sinavGuncelle = db.Sinav.Where(x => x.Sinav_ID.ToString() == labelControl4.Text).FirstOrDefault();

                sinavGuncelle.Tarihi = txtSinavTarihi.Text;
                sinavGuncelle.SinavTuru_ID = Convert.ToInt32(labelControl2.Text);
                sinavGuncelle.saat = cbSinavSaati.Text;

                GENEL_LOG("SINAV BİLGİLERİ GÜNCELLENDİ", "*******");
                db.SaveChanges();
                Listele();
                Temizle();
                XtraMessageBox.Show("BAŞARILI ŞEKİLDE GÜNCELLENDİ", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception hata1)
            {
                GENEL_LOG(hata1.Message, hata1.StackTrace);
                XtraMessageBox.Show("HATA", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

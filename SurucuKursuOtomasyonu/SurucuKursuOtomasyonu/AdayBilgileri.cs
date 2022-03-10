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
    public partial class AdayBilgileri : DevExpress.XtraEditors.XtraForm
    {
        public AdayBilgileri()
        {
            InitializeComponent();
        }
        SurucuKursuEntities db = new SurucuKursuEntities();
        public string SilenKİSİ;
        public string kullaniciID;

        public void LOG_SİLKayit(int ıd,string adsoyad,string tc,string Telefon,string Adres)
        {
           
            LOG_Sil logSil = new LOG_Sil();
            logSil.ID = ıd;
            logSil.adiSoyadi = adsoyad;
            logSil.TC = tc;
            logSil.telefon = Telefon;
            logSil.adres = Adres;
            logSil.SilenKisi =SilenKİSİ ;
            logSil.silmeTarihi = DateTime.Now.ToString("dd.MM.yyyy HH:mm");
            db.LOG_Sil.Add(logSil);
            db.SaveChanges();

        }

        public void GENEL_LOG(string message, string stackTrace)
        {
            int id = Convert.ToInt32(kullaniciID);
            Genel_LOG log = new Genel_LOG();
            log.ID = id;
            log.Adi_Soyadi = SilenKİSİ;
            log.islemTarihi = DateTime.Now.ToString("dd.MM.yyyy HH:mm");
            log.Mesaj = message;
            log.StackTrace = stackTrace;

            db.Genel_LOG.Add(log);
            db.SaveChanges();
        }


        private void AdliVar_CheckedChanged(object sender, EventArgs e)
        {
            
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
            

            if (SaglikVar.Checked == true)
            {
                SaglikYok.Enabled = false;
            }

            if (SaglikVar.Checked == false)
            {
                SaglikYok.Enabled = true;
            }
        }

        private void Saglikyok_CheckedChanged(object sender, EventArgs e)
        {
           

            if (SaglikYok.Checked == true)
            {
                SaglikVar.Enabled = false;
            }

            if (SaglikYok.Checked == false)
            {
                SaglikVar.Enabled = true;
            }
        }

        public void Listele()
        {
            var AdayBilgi = (from x in db.Kursiyer
                             select new
                             {
                                 ID = x.Kursiyer_ID,
                                 x.Adi,
                                 x.Soyadi,
                                 x.TC,
                                 x.Adres,
                                 x.OgrenimDurumu,
                                 x.KayitTarihi,
                                 x.Telefon,
                                 x.DogumTarih,
                                 x.AdliBelge,
                                 x.SaglikRaporu
                             }).ToList();
            gridControl1.DataSource = AdayBilgi;
        }

        private void AdayBilgileri_Load(object sender, EventArgs e)
        {
            Listele();
            if (kullaniciID != "1") simpleButton1.Enabled = simpleButton2.Enabled = false;
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtID.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            txtAdi.Text = gridView1.GetFocusedRowCellValue("Adi").ToString();
            txtSoyadi.Text= gridView1.GetFocusedRowCellValue("Soyadi").ToString();
            txtTc.Text= gridView1.GetFocusedRowCellValue("TC").ToString();
            txtAdres.Text= gridView1.GetFocusedRowCellValue("Adres").ToString();
            cbxOgrenimdurum.Text= gridView1.GetFocusedRowCellValue("OgrenimDurumu").ToString();
            //AdliBelge durumu
            if (gridView1.GetFocusedRowCellValue("AdliBelge").ToString() == true.ToString())
            {
                AdliVar.Checked = true;
                AdliYok.Checked = false;
            }
            else { AdliYok.Checked = true; AdliVar.Checked = false; }

            txtTarih.Text = gridView1.GetFocusedRowCellValue("KayitTarihi").ToString();
            txtTelefon.Text = gridView1.GetFocusedRowCellValue("Telefon").ToString();
            txtDogumTarihi.Text = gridView1.GetFocusedRowCellValue("DogumTarih").ToString();
            //SaglikRaporu durumu
            if (gridView1.GetFocusedRowCellValue("SaglikRaporu").ToString() == true.ToString())
            {
                SaglikVar.Checked = true;
                SaglikYok.Checked = false;
            }
            else { SaglikYok.Checked = true; SaglikVar.Checked = false; }
        }

        private void simpleButton2_Click_1(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = XtraMessageBox.Show("ID :"+txtID.Text+"\nAdı Soyadı :"+txtAdi.Text+" "+txtSoyadi.Text+"\nSilmek istedğinizden  eminmisiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dr == DialogResult.Yes)
                {
                    var aday = db.Kursiyer.Where(x => x.Kursiyer_ID.ToString() == txtID.Text).FirstOrDefault();

                  
                    LOG_SİLKayit(aday.Kursiyer_ID, aday.Adi + " " + aday.Soyadi, aday.TC, aday.Telefon, aday.Adres);
                    GENEL_LOG("KULLANICI SİLİNDİ","**********");

                    db.Kursiyer.Remove(aday);
                    db.SaveChanges();
                    Listele();
                    XtraMessageBox.Show("KAYIT SİLİNDİ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }   
            }
            catch (Exception hata)
            {
                GENEL_LOG(hata.Message, hata.StackTrace);

                XtraMessageBox.Show("HATA", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                var aday = db.Kursiyer.Where(x => x.Kursiyer_ID.ToString() == txtID.Text).FirstOrDefault();
                aday.Adi = txtAdi.Text;
                aday.Soyadi = txtSoyadi.Text;
                aday.TC = txtTc.Text;
                aday.Adres = txtAdres.Text;
                aday.OgrenimDurumu = cbxOgrenimdurum.Text;
                aday.AdliBelge = Convert.ToBoolean(AdliBelgeKontrol.Text);
                aday.KayitTarihi = txtTarih.Text;
                aday.Telefon = txtTelefon.Text;
                aday.DogumTarih = txtDogumTarihi.Text;
                aday.SaglikRaporu = Convert.ToBoolean(SaglikRaporuKontrol.Text);

                GENEL_LOG("KULLANICI GÜNCELLENDİ", "**********");

                db.SaveChanges();
                Listele();
                XtraMessageBox.Show("BAŞARILI ŞEKİLDE GÜNCELLENDİ", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception hata1)
            {
                GENEL_LOG(hata1.Message, hata1.StackTrace);

                XtraMessageBox.Show("HATA", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AdliVar_CheckedChanged_1(object sender, EventArgs e)
        {
            if (AdliVar.Checked == true)
            {
                AdliBelgeKontrol.Text = "True";
            }
            
        }

        private void AdliYok_CheckedChanged_1(object sender, EventArgs e)
        {
            if (AdliYok.Checked == true)
            {
                AdliBelgeKontrol.Text = "False";
            }
        }

        private void SaglikVar_CheckedChanged_1(object sender, EventArgs e)
        {
            if (SaglikVar.Checked == true)
            {
                SaglikRaporuKontrol.Text = "True";
            }
            
        }

        private void SaglikYok_CheckedChanged_1(object sender, EventArgs e)
        {
            if (SaglikYok.Checked == true)
            {
                SaglikRaporuKontrol.Text = "False";
            }
        }
    }
}

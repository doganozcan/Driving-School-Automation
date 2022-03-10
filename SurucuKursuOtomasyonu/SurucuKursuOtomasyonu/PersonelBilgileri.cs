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
    public partial class PersonelBilgileri : Form
    {
        public PersonelBilgileri()
        {
            InitializeComponent();
        }
        SurucuKursuEntities db = new SurucuKursuEntities();
        public string SilenKİSİ;
        public string kullaniciID;

        public void LOG_SİLKayit(int ıd, string adsoyad, string tc, string Telefon, string Adres)
        {

            LOG_Sil logSil = new LOG_Sil();
            logSil.ID = ıd;
            logSil.adiSoyadi = adsoyad;
            logSil.TC = tc;
            logSil.telefon = Telefon;
            logSil.adres = Adres;
            logSil.SilenKisi = SilenKİSİ;
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

        public void Listele()
        {
            var personel = (from x in db.Kullanici
                            select new
                            {
                                ID=x.Kullanici_ID,
                                x.Adi,
                                x.Soyadi,
                                x.TC,
                                x.Adres,
                                x.Telefon,
                                x.DogumTarihi,
                                x.Eposta,
                                Gorev=x.KullaniciTuru.Turu, //Görevi
                                x.maas,
                                x.Kullanici_Adi,
                                x.Kullanici_Sifre
                            }).ToList();
            gridControl1.DataSource = personel;
        }

        private void PersonelBilgileri_Load(object sender, EventArgs e)
        {
            Listele();
            this.ActiveControl = txtAdi;
            var gorevi = (from x in db.KullaniciTuru
                          select new
                          {
                              ID = x.KullaniciTuru_ID,
                              x.Turu
                          }).ToList();
            cbGorev.Properties.DisplayMember = "Turu";
            cbGorev.Properties.ValueMember = "ID";
            cbGorev.Properties.DataSource = gorevi;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                var personelGuncelle = db.Kullanici.Where(x => x.Kullanici_ID.ToString() == txtIDKontrol.Text).FirstOrDefault();

                personelGuncelle.Adi = txtAdi.Text;
                personelGuncelle.Soyadi = txtSoyadi.Text;
                personelGuncelle.TC = txtTc.Text;
                personelGuncelle.Adres = txtAdres.Text;
                personelGuncelle.Telefon = txtTelefon.Text;
                personelGuncelle.DogumTarihi = txtDogumTarihi.Text;
                personelGuncelle.Eposta = txtEposta.Text;
                personelGuncelle.KullaniciTuru_ID = Convert.ToInt32(labelControl9.Text);
                personelGuncelle.maas = Convert.ToInt32(txtMaas.Text);
                personelGuncelle.Kullanici_Adi = txtKullaniciAdi.Text;
                personelGuncelle.Kullanici_Sifre = txtSifre.Text;

                GENEL_LOG("PERSONEL GÜNCELLENDİ", "******");

                db.SaveChanges();

                Listele();
                XtraMessageBox.Show("BAŞARILI ŞEKİLDE GÜNCELLENDİ", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception hata)
            {
                GENEL_LOG(hata.Message, hata.StackTrace);

                XtraMessageBox.Show("Alanları boş bırakmayın", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtIDKontrol.Text = gridView1.GetFocusedRowCellValue("ID").ToString();

            txtAdi.Text = gridView1.GetFocusedRowCellValue("Adi").ToString();
            txtSoyadi.Text = gridView1.GetFocusedRowCellValue("Soyadi").ToString();
            txtTc.Text = gridView1.GetFocusedRowCellValue("TC").ToString();
            txtAdres.Text = gridView1.GetFocusedRowCellValue("Adres").ToString();
            txtTelefon.Text = gridView1.GetFocusedRowCellValue("Telefon").ToString();
            txtDogumTarihi.Text = gridView1.GetFocusedRowCellValue("DogumTarihi").ToString();
            txtEposta.Text = gridView1.GetFocusedRowCellValue("Eposta").ToString();
            cbGorev.Text = gridView1.GetFocusedRowCellValue("Gorev").ToString();
            txtMaas.Text= gridView1.GetFocusedRowCellValue("maas").ToString();
            txtKullaniciAdi.Text = gridView1.GetFocusedRowCellValue("Kullanici_Adi").ToString();
            txtSifre.Text = gridView1.GetFocusedRowCellValue("Kullanici_Sifre").ToString();

        }

       

        private void cbGorev_EditValueChanged(object sender, EventArgs e)
        {
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

        private void btnSil_Click(object sender, EventArgs e)
        {
            var personelSil = db.Kullanici.Where(x => x.Kullanici_ID.ToString() == txtIDKontrol.Text).FirstOrDefault();
            try
            {
                DialogResult dr = XtraMessageBox.Show(personelSil.Adi+" "+personelSil.Soyadi+ " Kişisini silmek istedğinizden  emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dr == DialogResult.Yes)
                {
                    GENEL_LOG("PERSONEL SİLİNDİ", "********");
                    LOG_SİLKayit(personelSil.Kullanici_ID,personelSil.Adi+" "+personelSil.Soyadi,personelSil.TC,personelSil.Telefon,personelSil.Adres);

                    db.Kullanici.Remove(personelSil);
                    db.SaveChanges();

                    Listele();
                    XtraMessageBox.Show("KAYIT SİLİNDİ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception hata1)
            {
                GENEL_LOG(hata1.Message, hata1.StackTrace);

                XtraMessageBox.Show("HATA", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

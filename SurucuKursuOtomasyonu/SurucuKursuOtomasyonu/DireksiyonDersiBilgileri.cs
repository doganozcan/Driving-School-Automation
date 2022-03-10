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
    public partial class DireksiyonDersiBilgileri : Form
    {
        public DireksiyonDersiBilgileri()
        {
            InitializeComponent();
        }
        SurucuKursuEntities db = new SurucuKursuEntities();
        public string SilenKİSİ;
        public string kullaniciID;

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
            var kursiyer_load = (from x in db.DireksiyonDersiKayit
                                 join y in db.KursiyerBelgeKayit on x.Kursiyer_ID equals y.Kursiyer_ID
                                 select new
                                 {
                                     ID = x.Kursiyer_ID,
                                     x.Kursiyer.Adi,
                                     x.Kursiyer.Soyadi,
                                     Ders_Tarihi=x.Tarih,
                                     y.SurucuBelgesiTuru.BelgeSinifi,
                                     y.SurucuBelgesiTuru.KullandigiArac
                                 }).ToList();
            gridControl1.DataSource = kursiyer_load;


        }

        private void DireksiyonDersiBilgileri_Load(object sender, EventArgs e)
        {
            Listele();
            if (kullaniciID != "1") simpleButton2.Enabled = false;
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            var D_Derssil = db.DireksiyonDersiKayit.Where(x => x.Kursiyer_ID.ToString() == labelControl1.Text).FirstOrDefault();
            try
            {
                DialogResult dr = XtraMessageBox.Show("Ders kaydını silmek istedğinizden  eminmisiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dr == DialogResult.Yes)
                {
                    GENEL_LOG("KURSİYERİN SINAV KAYDI SİLİNDİ", "******");

                    db.DireksiyonDersiKayit.Remove(D_Derssil);
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

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            labelControl1.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
        }
    }
}

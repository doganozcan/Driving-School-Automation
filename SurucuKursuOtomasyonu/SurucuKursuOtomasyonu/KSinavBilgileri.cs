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
    public partial class KSinavBilgileri : DevExpress.XtraEditors.XtraForm
    {
        public KSinavBilgileri()
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
            var sinavBilgi = (from x in db.KursiyerSinavKayit
                              select new
                              {
                                  ID = x.Kursiyer_ID,
                                  x.Kursiyer.TC,
                                  x.Kursiyer.Adi,
                                  x.Kursiyer.Soyadi,
                                  x.Kursiyer.Telefon,
                                  x.Sinav.Tarihi,
                                  x.Sinav.SinavTuru.SinavTuru1,
                                  x.Sinav.saat,
                                  x.KursiyerBelgeKayit.SurucuBelgesiTuru.BelgeSinifi
                              }).ToList();
            gridControl1.DataSource = sinavBilgi;
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            var sinavSil = db.KursiyerSinavKayit.Where(x => x.Kursiyer_ID.ToString() == labelControl1.Text).FirstOrDefault();
            try
            {
                DialogResult dr = XtraMessageBox.Show("Sınav kaydını silmek istedğinizden  eminmisiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dr == DialogResult.Yes)
                {
                    GENEL_LOG("KURSİYERİN SINAV KAYDI SİLİNDİ", "******");
                    
                    db.KursiyerSinavKayit.Remove(sinavSil);
                    db.SaveChanges();

                    Listele();
                    XtraMessageBox.Show("KAYIT SİLİNDİ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception hata)
            {
                GENEL_LOG(hata.Message,hata.StackTrace);
                XtraMessageBox.Show("HATA", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void KSinavBilgileri_Load(object sender, EventArgs e)
        {
            Listele();
            if (kullaniciID != "1") simpleButton2.Enabled = false;
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            labelControl1.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
        }
    }
}

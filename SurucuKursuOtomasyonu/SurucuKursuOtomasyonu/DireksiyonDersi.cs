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
    public partial class DireksiyonDersi : Form
    {
        public DireksiyonDersi()
        {
            InitializeComponent();
        }
        SurucuKursuEntities db = new SurucuKursuEntities();
        public int Kullanici_ID;
        public string K_adiSoyadi;

        public void GENEL_LOG(string message, string stackTrace)
        {
            int id = Kullanici_ID;
            Genel_LOG log = new Genel_LOG();
            log.ID = id;
            log.Adi_Soyadi = K_adiSoyadi;
            log.islemTarihi = DateTime.Now.ToString("dd.MM.yyyy HH:mm");
            log.Mesaj = message;
            log.StackTrace = stackTrace;

            db.Genel_LOG.Add(log);
            db.SaveChanges();
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
                             }).ToList();
            gridControl1.DataSource = AdayBilgi;
        }

        private void DireksiyonDersi_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                DireksiyonDersiKayit ders = new DireksiyonDersiKayit();
                ders.Kursiyer_ID = Convert.ToInt32(txtID.Text);
                ders.Tutar = Convert.ToInt32(txtTutar.Text);
                ders.Tarih = tarih.Text;
                ders.KaydedenKullanici_ID = Kullanici_ID;

                var bakiye = db.KursiyerBakiye.Where(x => x.Kursiyer_ID.ToString() == txtID.Text).FirstOrDefault();
                bakiye.Borc = bakiye.Borc + Convert.ToInt32(txtTutar.Text);

                GENEL_LOG("KURSİYER DİREKSİYON DERSİNE KAYDEDİLDİ", "***********");

                db.DireksiyonDersiKayit.Add(ders);
                db.SaveChanges();
                txtTutar.Text = "";
                tarih.Text = "";
                XtraMessageBox.Show("Derse başarılı şekilde kaydı yapıldı.", "Tamamlandı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception hata)
            {
                GENEL_LOG(hata.Message, hata.StackTrace);
                XtraMessageBox.Show("Hata", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtID.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
        }
    }
}

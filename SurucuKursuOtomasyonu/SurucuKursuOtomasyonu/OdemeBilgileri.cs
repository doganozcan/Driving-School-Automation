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
    public partial class OdemeBilgileri : Form
    {
        public OdemeBilgileri()
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

        public void Listele()
        {
            var aday = (from x in db.KursiyerBakiye
                        select new
                        {
                            ID = x.Kursiyer_ID,
                            x.Kursiyer.TC,
                            Kalan_Borç = x.Borc,
                            x.Kursiyer.Adi,
                            x.Kursiyer.Soyadi
                        }).ToList();
            gridControl1.DataSource = aday;
        }

        private void OdemeBilgileri_Load(object sender, EventArgs e)
        {
            Listele();
            var odemeTuru = (from x in db.OdemeTuru
                             select new
                             {
                                 ID = x.OdemeTuru_ID,
                                 Türü = x.Turu
                             }).ToList();

            cbOdemeTuru.Properties.DisplayMember = "Türü";
            cbOdemeTuru.Properties.ValueMember = "ID";
            cbOdemeTuru.Properties.DataSource = odemeTuru;
        }

        public void SatırRenk()
        {
            var kontrol = db.KursiyerBakiye.Where(x => x.Kursiyer_ID.ToString() == txtID.Text).FirstOrDefault();
            if (kontrol.Borc == 0) gridView1.Appearance.FocusedRow.BackColor = Color.Green;
            else gridView1.Appearance.FocusedRow.BackColor = Color.Red;
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtID.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            SatırRenk();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            var yatır = db.KursiyerOdeme.Where(x => x.Kursiyer_ID.ToString() == txtID.Text).FirstOrDefault();

            try
            {
                var kontrol = db.KursiyerBakiye.Where(x => x.Kursiyer_ID.ToString() == txtID.Text).FirstOrDefault();

                if (txtTarih.Text == "" || cbOdemeTuru.Text == "" || txtOdemeTutar.Text == "")
                {
                    XtraMessageBox.Show("BOŞ ALANLARI DOLDURUN", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    if (kontrol.Borc == 0)
                    {
                        XtraMessageBox.Show("KURSİYERİN BORCU KALMADI", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        GENEL_LOG("ÖDEME YAPILDI", "*******");

                        yatır.Kursiyer_ID = Convert.ToInt32(txtID.Text);
                        yatır.Tutar = Convert.ToInt32(txtOdemeTutar.Text);
                        yatır.islemTarihi = DateTime.Now.ToString("dd.MM.yyyy HH:mm");
                        yatır.OdemeTuru_ID = Convert.ToInt32(labelControl1.Text);
                        yatır.KaydedenKullanici_ID = Convert.ToInt32(kullaniciID);

                        //int id = Convert.ToInt32(txtID.Text);          
                        //int tutar1 = Convert.ToInt32(txtOdemeTutar.Text);
                        //int Oturu = Convert.ToInt32(labelControl1.Text);
                        //int kID = Convert.ToInt32(kullaniciID);
                        //db.OdemeYap(id, tutar1, Oturu, kID);      STORED PROCEDURES

                        kontrol.Borc = kontrol.Borc - Convert.ToInt32(txtOdemeTutar.Text); 
                        kontrol.Odenen = kontrol.Odenen + Convert.ToInt32(txtOdemeTutar.Text);

                        db.KursiyerOdeme.Add(yatır);
                        db.SaveChanges();
                        txtTarih.Text = "";
                        txtOdemeTutar.Text = "";
                        Listele();
                        XtraMessageBox.Show("Ödeme başarılı şekilde yapıldı.", "Tamamlandı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
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
            var odemeTuru = db.OdemeTuru.Where(x => x.Turu == cbOdemeTuru.Text).FirstOrDefault();
            labelControl1.Text = odemeTuru.OdemeTuru_ID.ToString();
        }

        private void txtID_EditValueChanged(object sender, EventArgs e)
        {
            
        }
    }
}

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
    public partial class GenelRapor : DevExpress.XtraEditors.XtraForm
    {
        public GenelRapor()
        {
            InitializeComponent();
        }
        SurucuKursuEntities db = new SurucuKursuEntities();

        public void Listele()
        {
            var aday = db.Kursiyer.Count();
            labelControl1.Text ="Kusiyer Sayısı: "+aday.ToString();

            var personel = db.Kullanici.Count();
            labelControl2.Text ="Personel Sayısı: " +personel.ToString();

            var odeme = db.KursiyerOdeme.Sum(x => x.Tutar);
            labelControl3.Text = "Toplam Ödenen Para: "+odeme.ToString()+" TL";

            var Kalanodeme = db.KursiyerBakiye.Sum(x => x.Borc);
            labelControl4.Text = "Toplam Kalan Ödeme: "+Kalanodeme.ToString()+" TL";

            var ortMaas = db.Kullanici.Average(x => x.maas);
            ortMaas = Convert.ToInt32(ortMaas);

            labelControl5.Text = "Ortalama Maşş: " +ortMaas + " TL";
        }

        private void GenelRapor_Load(object sender, EventArgs e)
        {
            Listele();
        }
    }
}

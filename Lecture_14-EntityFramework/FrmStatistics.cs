using System;
using System.Linq;
using System.Windows.Forms;

namespace Lecture_14_EntityFramework
{
    public partial class FrmStatistics : Form
    {
        public FrmStatistics()
        {
            InitializeComponent();
        }

        TrainingCampEFEntities db = new TrainingCampEFEntities();

        private void FrmStatistics_Load(object sender, EventArgs e)
        {
            // Lokasyon Sayısı
            lblLocationCount.Text = db.Location.Count().ToString();

            // Toplam Kapasite
            lblSumCapacity.Text = db.Location.Sum(x => x.Capacity).ToString();

            // Rehber Sayısı
            lblGuideCount.Text = db.Guide.Count().ToString();

            // Ortalama Kapasite
            lblAvarageCapacity.Text = db.Location.Average(x => x.Capacity).Value.ToString("N2");

            // Ortalama Fiyat
            lblAvarageLocationPrice.Text = db.Location.Average(x => x.Price).Value.ToString("C2");

            // Son Eklenen Ülke
            lblLastCountry.Text = db.Location.OrderByDescending(x => x.Id).FirstOrDefault().Country;

            // Kapadokya'daki Tur Kapasitesi
            lblKapadokyaTourCapacity.Text = db.Location.Where(x => x.City == "Kapadokya").Sum(x => x.Capacity).ToString();

            // Türkiye'deki Ortalama Kapasite
            lblTurkeyAvarageCapacity.Text = db.Location.Where(x => x.Country == "Türkiye").Average(x => x.Capacity).Value.ToString("N2");

            // Roma Turunun Rehberinin Adı
            lblRomaGuideName.Text = db.Location.Include("Guide").FirstOrDefault(x => x.City == "Roma").Guide.Name;

            // En Fazla Kapasiteli Tur
            lblMaxCapacityLocation.Text = db.Location.OrderByDescending(x => x.Capacity).FirstOrDefault().City;

            // En Pahalı Tur
            lblMaxPriceLocation.Text = db.Location.OrderByDescending(x => x.Price).FirstOrDefault().City;

            // Ayşegül Çınar'ın Rehberlik Yaptığı Tur Sayısı
            lblAysegulCinarLocationCount.Text = db.Location.Count(x => x.Guide.Name == "Ayşegül" && x.Guide.Surname == "Çınar").ToString();

        }
    }
}

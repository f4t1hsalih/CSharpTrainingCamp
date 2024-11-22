using System;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Lecture_14_EntityFramework
{
    public partial class FrmLocation : Form
    {
        public FrmLocation()
        {
            InitializeComponent();
            List();
        }

        TrainingCampEFEntities db = new TrainingCampEFEntities();

        void List()
        {
            dataGridView1.DataSource = db.Location.ToList();
        }

        void Clear()
        {
            txtID.Clear();
            txtCity.Clear();
            txtCountry.Clear();
            nudCapacity.Value = 0;
            txtPrice.Clear();
            txtDayNight.Clear();
            cmbGuide.SelectedIndex = -1;
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            List();
        }

        private void FrmLocation_Load(object sender, EventArgs e)
        {
            var guides = db.Guide.Select(x => new
            {
                ID = x.Id,
                FullName = x.Name + " " + x.Surname
            }).ToList();
            cmbGuide.DataSource = guides;
            cmbGuide.DisplayMember = "FullName";
            cmbGuide.ValueMember = "ID";
            cmbGuide.SelectedIndex = -1;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Location location = new Location
            {
                City = txtCity.Text,
                Country = txtCountry.Text,
                Capacity = (byte)nudCapacity.Value,
                Price = Convert.ToDecimal(txtPrice.Text),
                DayNight = txtDayNight.Text,
                GuideId = (short)cmbGuide.SelectedValue
            };
            db.Location.Add(location);
            db.SaveChanges();
            MessageBox.Show("Ekleme İşlemi Başarılı", "Ekleme İşlemi", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Information);
            List();
            Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtID.Text);
            db.Location.Remove(db.Location.Find(id));
            db.SaveChanges();
            MessageBox.Show(id + " Numaralı Tur Başarıyla Silindi", "Silme İşlemi", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Warning);
            List();
            Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtID.Text);
            Location location = db.Location.Find(id);

            location.City = txtCity.Text;
            location.Country = txtCountry.Text;
            location.Capacity = (byte)nudCapacity.Value;
            location.Price = Convert.ToDecimal(txtPrice.Text);
            location.DayNight = txtDayNight.Text;
            location.GuideId = (short)cmbGuide.SelectedValue;

            db.SaveChanges();
            MessageBox.Show(id + " Numaralı Tur Başarıyla Güncellendi", "Güncelleme İşlemi", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Information);
            List();
            Clear();
        }

        private void btnGetById_Click(object sender, EventArgs e)
        {
            Location location = db.Location.Find(Convert.ToInt32(txtID.Text));
            txtCity.Text = location.City;
            txtCountry.Text = location.Country;
            nudCapacity.Value = (byte)location.Capacity;
            txtPrice.Text = location.Price.ToString();
            txtDayNight.Text = location.DayNight;
            cmbGuide.SelectedValue = location.GuideId;
        }

        private void btnGetByIdForButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtID.Text);
            dataGridView1.DataSource = db.Location.Where(x => x.Id == id).ToList();
        }
    }
}

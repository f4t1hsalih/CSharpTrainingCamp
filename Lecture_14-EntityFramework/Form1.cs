using System;
using System.Linq;
using System.Windows.Forms;

namespace Lecture_14_EntityFramework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            List();
        }

        TrainingCampEFEntities db = new TrainingCampEFEntities();

        void Clear()
        {
            txtID.Text = txtName.Text = txtSurname.Text = "";
        }
        void List()
        {
            var values = db.Guide.ToList();
            dataGridView1.DataSource = values;
        }
        Guide GetById(int id)
        {
            Guide value = db.Guide.Find(id);
            return value;
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            List();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Guide guide = new Guide();
            guide.Name = txtName.Text;
            guide.Surname = txtSurname.Text;
            db.Guide.Add(guide);
            db.SaveChanges();
            MessageBox.Show("Kullanıcı Başarıyla Eklendi.");
            Clear();
            List();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Guide guide = GetById(Convert.ToInt32(txtID.Text));
            db.Guide.Remove(guide);
            db.SaveChanges();
            MessageBox.Show("Kullanıcı Başarıyla Silindi.");
            Clear();
            List();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Guide guide = GetById(Convert.ToInt32(txtID.Text));
            guide.Name = txtName.Text;
            guide.Surname = txtSurname.Text;
            db.SaveChanges();
            MessageBox.Show("Kullanıcı Başarıyla Güncellendi.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            Clear();
            List();
        }

        private void btnGetById_Click(object sender, EventArgs e)
        {
            Guide guide = GetById(Convert.ToInt32(txtID.Text));
            txtID.Text = guide.Id.ToString();
            txtName.Text = guide.Name;
            txtSurname.Text = guide.Surname;
        }

        private void btnGetByIdForButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtID.Text);
            dataGridView1.DataSource = db.Guide.Where(x => x.Id == id).ToList();
        }
    }
}

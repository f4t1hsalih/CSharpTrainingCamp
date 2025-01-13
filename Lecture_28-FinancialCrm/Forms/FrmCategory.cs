using Lecture_28_FinancialCrm.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Lecture_28_FinancialCrm
{
    public partial class FrmCategory : Form
    {
        FinancialCrmEntities db = new FinancialCrmEntities();

        public FrmCategory()
        {
            InitializeComponent();
        }

        private void ClearForm()
        {
            txtID.Clear();
            txtName.Clear();
        }

        private void LoadCategories()
        {
            dgvCategories.DataSource = db.Categories.Select(x => new
            {
                ID = x.CategoryId,
                Kategori_Adı = x.Name
            }).ToList();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Uygulamadan çıkmak ister misiniz?", "Çıkış", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            FormNavigator.Navigate(this, new FrmDashboard());
        }

        private void btnBanks_Click(object sender, EventArgs e)
        {
            FormNavigator.Navigate(this, new FrmBank());
        }

        private void btnBills_Click(object sender, EventArgs e)
        {
            FormNavigator.Navigate(this, new FrmBills());
        }

        private void btnSpendings_Click(object sender, EventArgs e)
        {
            FormNavigator.Navigate(this, new FrmSpending());
        }

        private void btnBankProcess_Click(object sender, EventArgs e)
        {
            FormNavigator.Navigate(this, new FrmBankProcess());
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            FormNavigator.Navigate(this, new FrmSettings());
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Kategori adı boş bırakılamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Categories category = new Categories
            {
                Name = txtName.Text
            };
            db.Categories.Add(category);
            db.SaveChanges();
            MessageBox.Show("Kategori Başarıyla Eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearForm();
            LoadCategories();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text);
            Categories category = db.Categories.Find(id);
            category.Name = txtName.Text;
            db.SaveChanges();
            MessageBox.Show("Kategori Başarıyla Güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearForm();
            LoadCategories();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text);
            Categories category = db.Categories.Find(id);
            db.Categories.Remove(category);
            db.SaveChanges();
            MessageBox.Show("Kategori Başarıyla Silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearForm();
            LoadCategories();
        }

        private void FrmCategory_Load(object sender, EventArgs e)
        {
            LoadCategories();
        }

        private void dgvCategories_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRow = dgvCategories.SelectedCells[0].RowIndex;
            txtID.Text = dgvCategories.Rows[selectedRow].Cells[0].Value.ToString();
            txtName.Text = dgvCategories.Rows[selectedRow].Cells[1].Value.ToString();
        }
    }
}

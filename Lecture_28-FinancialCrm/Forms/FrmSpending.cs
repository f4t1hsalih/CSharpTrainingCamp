using Lecture_28_FinancialCrm.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Lecture_28_FinancialCrm
{
    public partial class FrmSpending : Form
    {
        FinancialCrmEntities db = new FinancialCrmEntities();

        public FrmSpending()
        {
            InitializeComponent();
        }

        private void ClearForm()
        {
            txtID.Clear();
            txtTitle.Clear();
            nudAmount.Value = 0;
            cmbCategory.SelectedIndex = 0;
        }

        private void LoadData()
        {
            var data = db.Spendings.Select(x => new
            {
                ID = x.SpendingId,
                Kategori = x.Categories.Name,
                Başlık = x.Title,
                Tutar = x.Amount,
                Tarih = x.Date,
            }).ToList();
            dgvSpending.DataSource = data;
        }

        private void LoadComboBox()
        {
            var categories = db.Categories.ToList();
            cmbCategory.DataSource = categories;
            cmbCategory.DisplayMember = "Name";
            cmbCategory.ValueMember = "CategoryId";
        }

        private void AddSpending()
        {
            if (txtTitle.Text == "" || nudAmount.Value == 0)
            {
                MessageBox.Show("Lütfen Tüm Alanları Doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Spendings spending = new Spendings();
                spending.CategoryId = (int)cmbCategory.SelectedValue;
                spending.Title = txtTitle.Text;
                spending.Amount = nudAmount.Value;
                spending.Date = DateTime.Now.Date;
                db.Spendings.Add(spending);
                db.SaveChanges();
                ClearForm();
                LoadData();
            }
        }

        private void UpdateSpending(int id)
        {
            if (txtTitle.Text == "" || nudAmount.Value == 0)
            {
                MessageBox.Show("Lütfen Tüm Alanları Doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Spendings spendings = db.Spendings.Find(id);
                spendings.Title = txtTitle.Text;
                spendings.Amount = nudAmount.Value;
                spendings.CategoryId = (int)cmbCategory.SelectedValue;
                db.SaveChanges();
                ClearForm();
                LoadData();
            }
        }

        private void DeleteSpending(int id)
        {
            Spendings spending = db.Spendings.Find(id);
            db.Spendings.Remove(spending);
            db.SaveChanges();
            LoadData();
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

        private void btnCategories_Click(object sender, EventArgs e)
        {
            FormNavigator.Navigate(this, new FrmCategory());
        }

        private void btnBanks_Click(object sender, EventArgs e)
        {
            FormNavigator.Navigate(this, new FrmBank());
        }

        private void btnBills_Click(object sender, EventArgs e)
        {
            FormNavigator.Navigate(this, new FrmBills());
        }

        private void btnBankProcess_Click(object sender, EventArgs e)
        {
            FormNavigator.Navigate(this, new FrmBankProcess());
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            FormNavigator.Navigate(this, new FrmSettings());
        }

        private void FrmSpending_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadComboBox();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddSpending();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtID.Text.Length == 0)
            {
                MessageBox.Show("Lütfen Bir Harcama Seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            UpdateSpending(Convert.ToInt32(txtID.Text));
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtID.Text.Length == 0)
            {
                MessageBox.Show("Lütfen Bir Harcama Seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DeleteSpending(Convert.ToInt32(txtID.Text));
        }

        private void dgvSpending_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRow = dgvSpending.SelectedCells[0].RowIndex;
            txtID.Text = dgvSpending.Rows[selectedRow].Cells[0].Value.ToString();
            txtTitle.Text = dgvSpending.Rows[selectedRow].Cells[2].Value.ToString();
            nudAmount.Value = Convert.ToDecimal(dgvSpending.Rows[selectedRow].Cells[3].Value);
            cmbCategory.Text = dgvSpending.Rows[selectedRow].Cells[1].Value.ToString();
        }
    }
}

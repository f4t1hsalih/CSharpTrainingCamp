﻿using Lecture_28_FinancialCrm.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Lecture_28_FinancialCrm
{
    public partial class FrmBills : Form
    {
        public FrmBills()
        {
            InitializeComponent();
        }

        FinancialCrmEntities db = new FinancialCrmEntities();

        private void GetBills()
        {
            var bills = db.Bills.ToList();
            dgvBills.DataSource = bills;
        }

        private void ClearForm()
        {
            txtID.Text = string.Empty;
            txtTitle.Text = string.Empty;
            txtAmount.Text = string.Empty;
            txtPeriod.Text = string.Empty;
        }

        private void AddBill()
        {
            Bills bill = new Bills();
            bill.Title = txtTitle.Text;
            bill.Amount = Convert.ToDecimal(txtAmount.Text);
            bill.Period = txtPeriod.Text;
            db.Bills.Add(bill);
            db.SaveChanges();
            ClearForm();
            GetBills();
        }

        private void UpdateBill(int billId)
        {
            Bills bill = db.Bills.Find(billId);
            bill.Title = txtTitle.Text;
            bill.Amount = Convert.ToDecimal(txtAmount.Text);
            bill.Period = txtPeriod.Text;
            db.SaveChanges();
            ClearForm();
            GetBills();
        }

        private void DeleteBill(int billId)
        {
            Bills bill = db.Bills.Find(billId);
            DialogResult result = MessageBox.Show($"{bill.Title} {bill.Period} isimli fatura silinecektir. Onaylıyor musunuz?", "Fatura Silme", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result ==DialogResult.OK)
            {
                db.Bills.Remove(bill);
                db.SaveChanges();
                ClearForm();
                GetBills();
            }
        }

        private void dgvBills_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRow = dgvBills.SelectedCells[0].RowIndex;
            txtID.Text = dgvBills.Rows[selectedRow].Cells[0].Value.ToString();
            txtTitle.Text = dgvBills.Rows[selectedRow].Cells[1].Value.ToString();
            txtAmount.Text = dgvBills.Rows[selectedRow].Cells[2].Value.ToString();
            txtPeriod.Text = dgvBills.Rows[selectedRow].Cells[3].Value.ToString();
        }

        private void FrmBills_Load(object sender, EventArgs e)
        {
            GetBills();
        }

        private void CloseForm(bool exitApplication)
        {
            lblClose.BackColor = System.Drawing.Color.Red;
            string message = exitApplication ? "Uygulamadan çıkmak ister misiniz?" : "Dashboard'a dönmek ister misiniz?";
            DialogResult result = MessageBox.Show(message, "Çıkış", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                if (exitApplication)
                    Application.Exit();
                else
                    this.Close();
            }
            else
            {
                lblClose.BackColor = System.Drawing.Color.Transparent;
            }
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            CloseForm(false);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            CloseForm(true);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddBill();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateBill(int.Parse(txtID.Text));
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteBill(int.Parse(txtID.Text));
        }

    }
}

using Lecture_28_FinancialCrm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Lecture_28_FinancialCrm
{
    public partial class FrmDashboard : Form
    {
        FinancialCrmEntities db = new FinancialCrmEntities();
        int counter = 0;

        // Fatura başlıkları ve etiket isimlerini tutan liste
        List<(string Title, string Label)> billTitles = new List<(string Title, string Label)>
        {
            ("Elektrik", "Elektrik Faturası"),
            ("Su", "Su Faturası"),
            ("Doğalgaz", "Doğalgaz Faturası"),
            ("İnternet", "İnternet Faturası")
        };

        public FrmDashboard()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Uygulamadan çıkmak ister misiniz?", "Çıkış", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void FrmDashboard_Load(object sender, EventArgs e)
        {
            try
            {
                lblTotalBalance.Text = db.Banks.Sum(b => b.Balance).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bakiye bilgisi alınamadı: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblTotalBalance.Text = "0.00 ₺";
            }

            LoadCharts();
            timer.Start();
        }

        private void LoadCharts()
        {
            try
            {
                // Chart1 verileri (Bankalar)
                var bankData = db.Banks.Select(x => new { x.Title, x.Balance }).ToList();
                chart1.Series["Banks"].Points.Clear();
                foreach (var item in bankData)
                {
                    chart1.Series["Banks"].Points.AddXY(item.Title, item.Balance);
                }

                // Chart2 verileri (Faturalar)
                var billData = db.Bills.Select(x => new { x.Title, x.Amount }).ToList();
                chart2.Series["Bills"].Points.Clear();
                foreach (var item in billData)
                {
                    chart2.Series["Bills"].Points.AddXY(item.Title, item.Amount);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Grafik bilgileri yüklenemedi: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            try
            {
                var index = counter % billTitles.Count;
                var bill = billTitles[index];

                label5.Text = bill.Label; // Fatura başlığını güncelle
                lblLastBills.Text = db.Bills.Where(x => x.Title == bill.Title)
                                            .Select(x => x.Amount)
                                            .FirstOrDefault()?.ToString("C2") ?? "0.00 ₺"; // Fatura miktarını güncelle
                counter++;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fatura bilgisi alınamadı: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBanks_Click(object sender, EventArgs e)
        {
            FormNavigator.Navigate(this, new FrmBank());
        }

        private void btnBills_Click(object sender, EventArgs e)
        {
            FormNavigator.Navigate(this, new FrmBills());
        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            FormNavigator.Navigate(this, new FrmCategory());
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
    }
}

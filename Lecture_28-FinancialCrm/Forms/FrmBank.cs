using Lecture_28_FinancialCrm.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Lecture_28_FinancialCrm
{
    public partial class FrmBank : Form
    {
        public FrmBank()
        {
            InitializeComponent();
        }

        FinancialCrmEntities db = new FinancialCrmEntities();

        private decimal GetBankBalance(string bankName)
        {
            var value = db.Banks.Where(x => x.Title == bankName).Select(x => x.Balance).FirstOrDefault();
            return value ?? 0;
        }

        private string GetBankProcesses(int lastId)
        {
            if (!db.BankProcesses.Any()) // İşlem yoksa kontrol
                return "Henüz işlem bulunmamaktadır.";

            var process = db.BankProcesses.OrderByDescending(x => x.BankProcessId)
                                           .Skip(lastId - 1)
                                           .Take(1)
                                           .FirstOrDefault();

            if (process == null) // Eğer sonuç null ise
                return "Henüz işlem bulunmamaktadır.";

            return $"{process.Date} - {process.Description} - {process.Amount} ₺";
        }

        private void FrmBank_Load(object sender, System.EventArgs e)
        {
            lblYapiKredi.Text = GetBankBalance("Yapı Kredi").ToString() + " ₺";
            lblZiraatBank.Text = GetBankBalance("Ziraat Bank").ToString() + " ₺";
            lblPapara.Text = GetBankBalance("Papara").ToString() + " ₺";

            lblBankProcess1.Text = GetBankProcesses(1);
            lblBankProcess2.Text = GetBankProcesses(2);
            lblBankProcess3.Text = GetBankProcesses(3);
            lblBankProcess4.Text = GetBankProcesses(4);
            lblBankProcess5.Text = GetBankProcesses(5);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Uygulamadan çıkmak ister misiniz?", "Çıkış", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void btnBills_Click(object sender, EventArgs e)
        {
            FormNavigator.Navigate(this, new FrmBills());
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            FormNavigator.Navigate(this, new FrmDashboard());
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

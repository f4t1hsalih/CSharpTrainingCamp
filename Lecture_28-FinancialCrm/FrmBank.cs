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

        private void lblClose_Click(object sender, EventArgs e)
        {
            CloseForm(false); // Dashboard'a dönüş
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            CloseForm(true); // Uygulama kapanışı
        }
    }
}

using System;
using System.Windows.Forms;

namespace Lecture_28_FinancialCrm
{
    public partial class FrmBankProcess : Form
    {
        public FrmBankProcess()
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

        private void btnSpendings_Click(object sender, EventArgs e)
        {
            FormNavigator.Navigate(this, new FrmSpending());
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            FormNavigator.Navigate(this, new FrmSettings());
        }
    }
}

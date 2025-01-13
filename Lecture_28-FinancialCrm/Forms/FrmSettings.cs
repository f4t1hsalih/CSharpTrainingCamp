using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture_28_FinancialCrm
{
    public partial class FrmSettings : Form
    {
        public FrmSettings()
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

        private void btnBankProcess_Click(object sender, EventArgs e)
        {
            FormNavigator.Navigate(this, new FrmBankProcess());
        }
    }
}

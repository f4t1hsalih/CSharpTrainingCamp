using System;
using System.Windows.Forms;

namespace Lecture_28_FinancialCrm
{
    public partial class FrmDashboard : Form
    {
        public FrmDashboard()
        {
            InitializeComponent();
        }

        private void OpenForm(Form form)
        {
            form.FormClosed += (s, args) => this.Show(); // Form kapandığında Dashboard'u tekrar göster
            form.Show();
            this.Hide(); // Dashboard'u gizle
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            lblClose.BackColor = System.Drawing.Color.Red;
            DialogResult result = MessageBox.Show(
                "Uygulamadan çıkmak ister misiniz?",
                "Çıkış",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.OK)
                Application.Exit();
            else
                lblClose.BackColor = System.Drawing.Color.Transparent;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Uygulamadan çıkmak ister misiniz?",
                "Çıkış",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.OK)
                Application.Exit();
        }

        private void btnBanks_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmBank());
        }

        private void btnBills_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmBills());
        }
    }
}

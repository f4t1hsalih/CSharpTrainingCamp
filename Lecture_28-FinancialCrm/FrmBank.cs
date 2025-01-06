using System.Windows.Forms;

namespace Lecture_28_FinancialCrm
{
    public partial class FrmBank : Form
    {
        public FrmBank()
        {
            InitializeComponent();
        }

        private void lblClose_Click(object sender, System.EventArgs e)
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

    }
}

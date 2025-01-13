using Lecture_28_FinancialCrm.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Lecture_28_FinancialCrm.Forms
{
    public partial class FrmLogin : Form
    {
        FinancialCrmEntities db = new FinancialCrmEntities();
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            lblExit.BackColor = System.Drawing.Color.Red;

            DialogResult result = MessageBox.Show("Uygulamadan çıkmak ister misiniz?", "Çıkış", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
            else
            {
                lblExit.BackColor = System.Drawing.Color.Transparent;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Kullanıcı adı ve şifre boş bırakılamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            Users user = db.Users.FirstOrDefault(x => x.Username == username && x.Password == password);
            if (user != null)
            {
                FormNavigator.Navigate(this, new FrmDashboard());
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

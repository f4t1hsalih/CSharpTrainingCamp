using Lecture_28_FinancialCrm.Helpers;
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

            DialogResult result = MessageBox.Show("Uygulamadan Çıkmak İster Misiniz?", "Çıkış", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
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
                MessageBox.Show("Kullanıcı Adı Ve Şifre Boş Bırakılamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string username = txtUsername.Text;
            string password = txtPassword.Text;

            // Kullanıcının girdiği şifreyi hashliyoruz
            string hashedPassword = HashHelper.HashPassword(password);

            // Veritabanında kullanıcının şifresini ve kullanıcı adını kontrol ediyoruz
            Users user = db.Users.FirstOrDefault(x => x.Username == username && x.Password == hashedPassword);

            if (user != null)
            {
                // Kullanıcı adı ve şifre doğruysa, ana sayfaya yönlendiriyoruz
                FormNavigator.Navigate(this, new FrmDashboard());
            }
            else
            {
                // Hatalı giriş durumunda kullanıcıya mesaj gösteriyoruz
                MessageBox.Show("Kullanıcı Adı Veya Şifre Hatalı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

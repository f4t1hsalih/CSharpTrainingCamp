using Lecture_28_FinancialCrm.Helpers; // HashHelper sınıfını ekliyoruz
using Lecture_28_FinancialCrm.Models;
using System;
using System.Data.Entity.Validation;
using System.Linq;
using System.Windows.Forms;

namespace Lecture_28_FinancialCrm
{
    public partial class FrmSettings : Form
    {
        FinancialCrmEntities db = new FinancialCrmEntities();

        public FrmSettings()
        {
            InitializeComponent();
        }

        private void ClearTextBoxes()
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtNewPassword.Clear();
            txtNewPasswordConfirm.Clear();
        }

        private void ShowMessage(string message, System.Drawing.Color color)
        {
            lblMessage.Visible = true;
            lblMessage.ForeColor = color;
            lblMessage.Text = message;
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string newPassword = txtNewPassword.Text;
            string newPasswordConfirm = txtNewPasswordConfirm.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(newPassword) || string.IsNullOrEmpty(newPasswordConfirm))
            {
                ShowMessage("Lütfen Tüm Alanları Doldurunuz.", System.Drawing.Color.Red);
                return;
            }

            // Şifre doğrulaması
            // Kullanıcının girdiği şifreyi hash'leyip veritabanındaki şifre ile karşılaştırıyoruz
            string hashedPassword = HashHelper.HashPassword(password);
            Users user = db.Users.FirstOrDefault(x => x.Username == username && x.Password == hashedPassword);

            if (user == null)
            {
                ShowMessage("Kullanıcı Adı Veya Şifre Hatalı.", System.Drawing.Color.Red);
                return;
            }
            else
            {
                if (newPassword != newPasswordConfirm)
                {
                    ShowMessage("Yeni Şifreler Uyuşmuyor.", System.Drawing.Color.Red);
                    return;
                }
                else
                {
                    // Yeni şifreyi hash'leyip kaydediyoruz
                    user.Password = HashHelper.HashPassword(newPassword);
                    try
                    {
                        db.SaveChanges();
                        ShowMessage("Şifre Başarıyla Değiştirildi.", System.Drawing.Color.Green);
                        ClearTextBoxes();
                    }
                    catch (DbEntityValidationException ex)
                    {
                        // Hata mesajlarını yazdır
                        foreach (var validationErrors in ex.EntityValidationErrors)
                        {
                            foreach (var validationError in validationErrors.ValidationErrors)
                            {
                                Console.WriteLine("Property: " + validationError.PropertyName + " Error: " + validationError.ErrorMessage);
                                MessageBox.Show("Hata: " + validationError.ErrorMessage);
                            }
                        }
                    }
                }
            }
        }

        private void btnVisiblePassword_Click(object sender, EventArgs e)
        {
            if (txtPassword.UseSystemPasswordChar == true)
                txtPassword.UseSystemPasswordChar = false;
            else
                txtPassword.UseSystemPasswordChar = true;
        }

        private void btnVisibleNewPassword_Click(object sender, EventArgs e)
        {
            if (txtNewPassword.UseSystemPasswordChar == true)
                txtNewPassword.UseSystemPasswordChar = false;
            else
                txtNewPassword.UseSystemPasswordChar = true;
        }

        private void btnVisibleNewPasswordConfirm_Click(object sender, EventArgs e)
        {
            if (txtNewPasswordConfirm.UseSystemPasswordChar == true)
                txtNewPasswordConfirm.UseSystemPasswordChar = false;
            else
                txtNewPasswordConfirm.UseSystemPasswordChar = true;
        }
    }
}

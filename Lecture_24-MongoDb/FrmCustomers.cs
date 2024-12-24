using Lecture_24_MongoDb.Entities;
using Lecture_24_MongoDb.Services;
using System;
using System.Windows.Forms;

namespace Lecture_24_MongoDb
{
    public partial class FrmCustomers : Form
    {
        CustomerOperations customerOperations = new CustomerOperations();

        public FrmCustomers()
        {
            InitializeComponent();
        }

        private void ClearFields()
        {
            txtName.Clear();
            txtSurname.Clear();
            txtCity.Clear();
            txtBalance.Clear();
            txtShoppingCount.Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var customer = new Customer
            {
                Name = txtName.Text,
                Surname = txtSurname.Text,
                City = txtCity.Text,
                Balance = Convert.ToDecimal(txtBalance.Text),
                ShoppingCount = Convert.ToInt32(txtShoppingCount.Text)
            };
            customerOperations.InsertCustomer(customer);
            MessageBox.Show("Müşteri Ekleme İşlemi Başarılı");
            ClearFields();
        }
    }
}

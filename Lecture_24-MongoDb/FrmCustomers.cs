using Lecture_24_MongoDb.Entities;
using Lecture_24_MongoDb.Services;
using System;
using System.Collections.Generic;
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

        private void CustomerList()
        {
            dataGridView1.DataSource = customerOperations.GetCustomerList();
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
            CustomerList();
        }

        private void FrmCustomers_Load(object sender, EventArgs e)
        {
            CustomerList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string value = txtID.Text;
            if (string.IsNullOrEmpty(value))
            {
                MessageBox.Show("Lütfen bir ID değeri giriniz.");
                return;
            }
            customerOperations.DeleteCustomer(value);
            CustomerList();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var updateCustomer = new Customer
            {
                CustomerId = txtID.Text,
                Name = txtName.Text,
                Surname = txtSurname.Text,
                City = txtCity.Text,
                Balance = Convert.ToDecimal(txtBalance.Text),
                ShoppingCount = int.Parse(txtShoppingCount.Text)
            };
            customerOperations.UpdateCustomer(updateCustomer);
            MessageBox.Show("Müşteri Başarıyla Güncellendi");
            ClearFields();
            CustomerList();
        }

        private void GetById_Click(object sender, EventArgs e)
        {
            string id = txtID.Text;
            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Lütfen bir ID değeri giriniz.");
                return;
            }
            var customer = customerOperations.GetCustomerById(id);
            txtName.Text = customer.Name;
            txtSurname.Text = customer.Surname;
            txtCity.Text = customer.City;
            txtBalance.Text = customer.Balance.ToString();
            txtShoppingCount.Text = customer.ShoppingCount.ToString();
            dataGridView1.DataSource = new List<Customer> { customer };
        }
    }
}

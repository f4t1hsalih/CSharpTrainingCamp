using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;

namespace Lecture_26_PostgreSQL
{
    public partial class FrmCustomer : Form
    {
        string connectionString = "Server=localhost;Port=5432;User Id=postgres;Password=SS.pass.4135;Database=CustomerDb;";

        void ClearFields()
        {
            txtID.Clear();
            txtName.Clear();
            txtSurname.Clear();
            txtCity.Clear();
        }
        void GetAllCustomers()
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Customers";
                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                {
                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dgvCustomers.DataSource = dataTable;
                    }
                }
            }
        }

        public FrmCustomer()
        {
            InitializeComponent();
        }

        private void FrmCustomer_Load(object sender, EventArgs e)
        {
            GetAllCustomers();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string surname = txtSurname.Text;
            string city = txtCity.Text;

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                string query = "Insert Into Customers (CustomerName, CustomerSurname, CustomerCity) values (@name, @surname, @city)";
                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@surname", surname);
                    command.Parameters.AddWithValue("@city", city);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Ekleme İşlemi Başarılı");
                }
            }
            ClearFields();
            GetAllCustomers();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text);
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                string query = "Delete From Customers Where CustomerID = @id";
                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Silme İşlemi Başarılı");
                }
            }
            ClearFields();
            GetAllCustomers();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string surname = txtSurname.Text;
            string city = txtCity.Text;
            int id = int.Parse(txtID.Text);
            using(NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                string query = "Update Customers Set CustomerName = @name, CustomerSurname = @surname, CustomerCity = @city Where CustomerID = @id";
                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@surname", surname);
                    command.Parameters.AddWithValue("@city", city);
                    command.Parameters.AddWithValue("@id", id);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Güncelleme İşlemi Başarılı");
                }
            }
            ClearFields();
            GetAllCustomers();
        }
    }
}

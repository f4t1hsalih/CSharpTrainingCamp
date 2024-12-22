using Dapper;
using Lecture_22_Dapper.DTOs;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Lecture_22_Dapper
{
    public partial class FrmProduct : Form
    {
        public FrmProduct()
        {
            InitializeComponent();
        }

        string connectionString = "Data Source=.\\SQLEXPRESS;initial Catalog=C#CampByMuratYucedag;integrated security=true;Trusted_Connection=True;TrustServerCertificate=True;";

        private async void ListProductsAsync()
        {
            using (var connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Products";
                var products = await connection.QueryAsync<ProductResultDTO>(query);
                dataGridView1.DataSource = products;
            }
        }

        private async void GetProductCountAsync()
        {
            using (var connection = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM Products";
                var count = await connection.QueryFirstOrDefaultAsync<int>(query);
                lblTotalProductCount.Text = count.ToString();
            }
        }

        private async void MaxPriceProductNameAsync()
        {
            using (var connection = new SqlConnection(connectionString))
            {
                string query = "SELECT Name FROM Products where Price = (select max(Price) from Products)";
                var count = await connection.QueryFirstOrDefaultAsync<string>(query);
                lblMaxPriceProduct.Text = count.ToString();
            }
        }

        private async void GetStatusTrueCountAsync()
        {
            using (var connection = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM Products WHERE Status = 1";
                var count = await connection.QueryFirstOrDefaultAsync<int>(query);
                lblActiveProductCount.Text = count.ToString();
            }
        }

        private void FrmProduct_Load(object sender, EventArgs e)
        {
            ListProductsAsync();
            GetProductCountAsync();
            MaxPriceProductNameAsync();
            GetStatusTrueCountAsync();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Products (Name, Price , Status) VALUES (@Name, @Price, @Status)";
                //sqlConnection.Execute(query, new { Name = txtName.Text, Price = txtPrice.Text, Status = true });
                var parameters = new DynamicParameters();
                parameters.Add("@Name", txtName.Text);
                parameters.Add("@Price", txtPrice.Text);
                parameters.Add("@Status", true);
                connection.Execute(query, parameters);
                ListProductsAsync();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtID.Text))
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM Products WHERE Id = @Id";
                    connection.Execute(query, new { Id = txtID.Text });
                    txtID.Clear();
                    ListProductsAsync();
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE Products SET Name = @Name, Price = @Price, Status = @Status WHERE Id = @Id";
                connection.Execute(query, new { Name = txtName.Text, Price = txtPrice.Text, Status = true, Id = txtID.Text });
                ListProductsAsync();
            }
        }
    }
}

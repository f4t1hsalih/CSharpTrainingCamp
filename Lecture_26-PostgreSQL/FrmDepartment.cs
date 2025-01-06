using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;

namespace Lecture_26_PostgreSQL
{
    public partial class FrmDepartment : Form
    {
        private string connectionString = "Server=localhost;Port=5432;User Id=postgres;Password=SS.pass.4135;Database=CustomerDb;";
        public FrmDepartment()
        {
            InitializeComponent();
        }

        void ClearFields()
        {
            txtID.Clear();
            txtName.Clear();
        }

        void GetAllDepartments()
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Departments";
                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                {
                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dgvDepartments.DataSource = dataTable;
                    }
                }
            }
        }

        private void FrmDepartment_Load(object sender, EventArgs e)
        {
            GetAllDepartments();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO Departments (Name) VALUES (@Name)";
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Name", txtName.Text);
                    command.ExecuteNonQuery();
                    GetAllDepartments();
                    ClearFields();
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string query = "UPDATE Departments SET Name = @Name WHERE ID = @ID";
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ID", txtID.Text);
                    command.Parameters.AddWithValue("@Name", txtName.Text);
                    command.ExecuteNonQuery();
                    GetAllDepartments();
                    ClearFields();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM Departments WHERE ID = @ID";
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ID", txtID.Text);
                    command.ExecuteNonQuery();
                    GetAllDepartments();
                    ClearFields();
                }
            }
        }
    }
}

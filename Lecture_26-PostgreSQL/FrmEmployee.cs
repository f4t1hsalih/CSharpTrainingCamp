using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;

namespace Lecture_26_PostgreSQL
{
    public partial class FrmEmployee : Form
    {
        private readonly string _connectionString = "Server=localhost;Port=5432;User Id=postgres;Password=SS.pass.4135;Database=CustomerDb;";

        public FrmEmployee()
        {
            InitializeComponent();
        }

        private void ClearFields()
        {
            txtID.Clear();
            txtName.Clear();
            txtSurname.Clear();
            txtSalary.Clear();
            cmbDepartment.SelectedIndex = -1;
        }

        private DataTable ExecuteQuery(string query)
        {
            using (var connection = new NpgsqlConnection(_connectionString))
            {
                using (var command = new NpgsqlCommand(query, connection))
                {
                    using (var adapter = new NpgsqlDataAdapter(command))
                    {
                        var dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        return dataTable;
                    }
                }
            }
        }

        private void GetAllEmployees()
        {
            string query = "SELECT * FROM employees";
            dgvEmployees.DataSource = ExecuteQuery(query);
        }

        private void FillComboBoxWithDepartments()
        {
            string query = "SELECT departmentid, name FROM departments";
            var dataTable = ExecuteQuery(query);
            cmbDepartment.DataSource = dataTable;
            cmbDepartment.DisplayMember = "name";
            cmbDepartment.ValueMember = "departmentid";
        }

        private void AddEmployee()
        {
            string query = "INSERT INTO employees (name, surname, salary, departmentid) VALUES (@name, @surname, @salary, @departmentid)";
            using (var connection = new NpgsqlConnection(_connectionString))
            {
                using (var command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@name", txtName.Text);
                    command.Parameters.AddWithValue("@surname", txtSurname.Text);
                    command.Parameters.AddWithValue("@salary", Convert.ToDecimal(txtSalary.Text));
                    command.Parameters.AddWithValue("@departmentid", cmbDepartment.SelectedValue);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        private void FrmEmployee_Load(object sender, EventArgs e)
        {
            FillComboBoxWithDepartments();
            GetAllEmployees();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddEmployee();
            ClearFields();
            GetAllEmployees();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM employees WHERE employeeid = @employeeid";
            using (var connection = new NpgsqlConnection(_connectionString))
            {
                using (var command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@employeeid", Convert.ToInt32(txtID.Text));
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
            ClearFields();
            GetAllEmployees();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string query = "UPDATE employees SET name = @name, surname = @surname, salary = @salary, departmentid = @departmentid WHERE employeeid = @employeeid";
            using (var connection = new NpgsqlConnection(_connectionString))
            {
                using (var command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@name", txtName.Text);
                    command.Parameters.AddWithValue("@surname", txtSurname.Text);
                    command.Parameters.AddWithValue("@salary", Convert.ToDecimal(txtSalary.Text));
                    command.Parameters.AddWithValue("@departmentid", cmbDepartment.SelectedValue);
                    command.Parameters.AddWithValue("@employeeid", Convert.ToInt32(txtID.Text));
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
            ClearFields();
            GetAllEmployees();
        }
    }
}

using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;

namespace Lecture_26_PostgreSQL
{
    public partial class FrmDepartment : Form
    {
        private string connectionString = "Server=localhost;Port=5432;User Id=postgres;Password=SS.pass.4135;Database=CustomerDb;";

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

        public FrmDepartment()
        {
            InitializeComponent();
        }

        private void FrmDepartment_Load(object sender, EventArgs e)
        {
            GetAllDepartments();
        }
    }
}

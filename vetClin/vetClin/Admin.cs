using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vetClin
{
    public partial class Admin : Form
    {
        public Admin(string connectString)
        {
            InitializeComponent();
            this.connectString = connectString;
        }
        public string connectString;
        bool KlinikaIsActive = false;
        bool SotrudIsAktive = false;
        bool usersIsActive = false;

        private void Klinika_Click(object sender, EventArgs e)
        {
            KlinikaIsActive = true;
            SotrudIsAktive = false;
            usersIsActive = false;
            SqlConnection connect = new SqlConnection(connectString); 

             string SelectTableKlin = "SELECT * FROM Klinika"; 
            

            using (connect)
            {
                connect.Open();
                SqlDataAdapter CreateTableKlin = new SqlDataAdapter(SelectTableKlin, connect);
                DataTable dataTable = new DataTable();

                CreateTableKlin.Fill(dataTable);

                dataGridView1.DataSource = dataTable;

                connect.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Sotrudniki_Click(object sender, EventArgs e)

        {
            KlinikaIsActive = false;
            SotrudIsAktive = true;
            usersIsActive = false;
            SqlConnection connect = new SqlConnection(connectString); 
            using (connect)
            {
                connect.Open();
                string SelectTableKlin = "SELECT * FROM Sklad, Lekarstva";
                SqlDataAdapter CreateTableKlin = new SqlDataAdapter(SelectTableKlin, connect);
                DataTable dataTable = new DataTable();

                CreateTableKlin.Fill(dataTable);

                dataGridView1.DataSource = dataTable;
                connect.Close();
            }
        }

        private void saveButt_Click(object sender, EventArgs e)
        {

            SqlConnection connect = new SqlConnection(connectString);
            if 
            string query = "INSERT INTO MyTable (Name, Age) VALUES (@Name, @Age)";
            using (SqlCommand command = new SqlCommand(query, connect))
            {

                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@Age", age);
                command.ExecuteNonQuery();
            }
        }
    }
}

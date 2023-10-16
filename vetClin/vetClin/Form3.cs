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
    public partial class Form3 : Form
    {
        

        public Form3(string connectString)
        {
            InitializeComponent();
            this.connectString = connectString;
            
            
        }
        public string connectString;
        
        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void хозяинToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection(connectString);
            Form6 Onwer = new Form6(connect);
            Onwer.Show();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection(connectString);
            string quertString = @"select id_onwer from Onwer";
            SqlCommand table = new SqlCommand(quertString, connect);
            connect.Open();
            SqlDataReader reader = table.ExecuteReader();
            int i = 0;
            dataGridView1.Rows.Clear();
            while (reader.Read()){
                dataGridView1.Rows.Add();
                dataGridView1[0, i].Value = reader[0];
                dataGridView1[1, i].Value = reader[1];
                i++;
            }
            reader.Close();
            connect.Close();
        }

        private void животноеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection(connectString);
            Form7 Karta = new Form7(connect);
            Karta.Show();
        }

       

        private void хозяинтToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

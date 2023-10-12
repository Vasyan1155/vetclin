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
    public partial class Form1 : Form
    {
        public Form1(SqlConnection con)
        {
            InitializeComponent();
            this.con = con;
        }
        public SqlConnection con;
        private void login_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2(con);
            newForm.Show();
            this.Hide();
            
        }
    }
}

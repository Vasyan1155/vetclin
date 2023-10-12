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
    public partial class Form7 : Form
    {
        public Form7(SqlConnection con)
        {
            InitializeComponent();
            this.con = con;
        }
        public SqlConnection con;
        private void Form7_Load(object sender, EventArgs e)
        {

        }
    }
}

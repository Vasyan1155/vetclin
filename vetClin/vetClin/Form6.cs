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
    public partial class Form6 : Form
    {
        public Form6(SqlConnection con)
        {
            InitializeComponent();
            this.con = con;
        }
        public SqlConnection con;
        private void Form6_Load(object sender, EventArgs e)
        {

        }
    }
}

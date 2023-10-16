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
    public partial class Form4 : Form
    {
        public Form4(String connectString)
        {
            InitializeComponent();
            this.connectString = connectString;
        }
        public string connectString;

    }
}

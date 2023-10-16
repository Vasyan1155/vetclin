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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectString = "Integrated Security = false; User Id = " + "user222_db" +
                "; Password = " + "user222" + ";Initial Catalog= " +
                "user222_db" + ";server=stud-mssql.sttec.yar.ru,38325";
            SqlConnection connect = new SqlConnection(connectString);
            Exception error = null;
            
            
            try
            {
                connect.Open();

            }
            catch (Exception ex)
            {
                error = ex;
                MessageBox.Show(string.Format("Error: {0}", ex.Message), "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {

                
                //string insertAvtor = "insert into AVTORIZACIYA values("
                using (connect)
                {
                    string idCOuntQ = "select COUNT(id_onwer) as 'id_onwer' from Onwer;";
                    int count = 0;
                    SqlCommand commandID = new SqlCommand(idCOuntQ, connect);
                    using (commandID)
                    {
                        SqlDataReader reader = commandID.ExecuteReader();
                        if (reader.Read())
                        {
                            count = Convert.ToInt32(reader["id_onwer"]);
                        }
                        reader.Close();
                    }
                    string insertOnwerQ = "insert into Onwer values(@id_onwer, @name, @addres, @login, @phone, @password);";
                    
                    SqlCommand insertOnwer = new SqlCommand(insertOnwerQ, connect);
                    insertOnwer.Parameters.AddWithValue("@login", textBox1.Text);
                    insertOnwer.Parameters.AddWithValue("@password", textBox2.Text);
                    insertOnwer.Parameters.AddWithValue("@name", textBox4.Text);
                    insertOnwer.Parameters.AddWithValue("@addres", textBox3.Text);
                    insertOnwer.Parameters.AddWithValue("@phone", textBox5.Text);
                    insertOnwer.Parameters.AddWithValue("id_onwer", count+1);
                    int rowsAffectedOwner = insertOnwer.ExecuteNonQuery();

                    string insertAvtQ = "insert into AVTORIZACIYA values (@id_owner,@login,@password, 'User')";
                    SqlCommand insertAvt = new SqlCommand(insertAvtQ, connect);
                    insertAvt.Parameters.AddWithValue("@id_owner", count + 1);
                    insertAvt.Parameters.AddWithValue("@login", textBox1.Text);
                    insertAvt.Parameters.AddWithValue("@password", textBox2.Text);
                    int rowsAffectedAvt = insertAvt.ExecuteNonQuery();
                    if (rowsAffectedOwner > 0 && rowsAffectedAvt > 0)
                    {
                        MessageBox.Show("Регистрация успешна!");
                    }else
                    {
                        MessageBox.Show("Пользователь уже есть или ошибка на сервере");
                    }
                    
                }
                connect.Close();
            }
            }
    }
}

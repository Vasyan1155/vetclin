using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vetClin
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            
        }
        public SqlConnection con;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectString = "Integrated Security = false; User Id = " + "user222_db" +
                "; Password = " + "user222" + ";Initial Catalog= " +
                "user222_db" + ";server=stud-mssql.sttec.yar.ru,38325";
            SqlConnection connect = new SqlConnection(connectString);
            Exception error = null;
            string loginQ = "SELECT login FROM AVTORIZACIYA where " + "'" +textBox1.Text +"'" + " like login;";
            string passwordQ = "SELECT password FROM AVTORIZACIYA where " + "'" + textBox2.Text + "'" + " like password;";
            string login = "";
            string password = "";
            string role = "";
            


           

            

            
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
                SqlCommand commandlog = new SqlCommand(loginQ, connect);
                SqlCommand commandpas = new SqlCommand(passwordQ, connect);
                
                using (connect)
                {
                    
                    using (commandlog)
                    {
                        SqlDataReader reader = commandlog.ExecuteReader();
                        
                        
                        if (reader.Read())
                        {
                            if (reader["login"].ToString() == textBox1.Text)
                            {
                                
                                login = reader["login"].ToString();

                            }
                            else
                            {
                                MessageBox.Show("Не тот логин");
                               

                            }
                            
                            
                        }
                        reader.Close();

                        SqlDataReader reader2 = commandpas.ExecuteReader();
                        if (reader2.Read())
                        {
                            if (reader2["password"].ToString() == textBox2.Text)
                            {
                                password = reader2["password"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("Не тот пароль");
                                
                            }
                            reader2.Close();
                        }
                        string roleQ = "SELECT doljnost FROM AVTORIZACIYA where login like" + " '" + login + "' " + "and password like " + " '" + password + "';";
                        SqlCommand commandRole = new SqlCommand(roleQ, connect);
                        SqlDataReader reader3 = commandRole.ExecuteReader();
                        if (reader3.Read())
                        {
                            role = reader3["doljnost"].ToString();
                            
                        }
                        reader3.Close();
                        
                    }
                    
                }
               
                if ( login == textBox1.Text && password == textBox2.Text && textBox1.Text != "") {
                    if (error == null)
                    {
                       
                        if (role == "Vrach")
                        {
                            Form3 newForm = new Form3(connectString);
                            newForm.Show();
                            this.Close();
                        }else if (role == "User")
                        {
                            Form4 newForm = new Form4(connectString);
                            newForm.Show();
                            this.Close();
                        }else if (role == "Admin")
                        {
                            Admin newForm = new Admin(connectString);
                            newForm.Show();
                            this.Close();
                        }
                    }
                    connect.Close();
                }
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}

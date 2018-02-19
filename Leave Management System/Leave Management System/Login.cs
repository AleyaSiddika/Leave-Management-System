using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OracleClient;

namespace Leave_Management_System
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SignUp newForm2= new SignUp();
            newForm2.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                connection CN = new connection();
                CN.thisConnection.Open();
                OracleCommand thisCommand = new OracleCommand();
                thisCommand.Connection = CN.thisConnection;
                if (textBox1.Text=="admin") {
                    thisCommand.CommandText = "SELECT * FROM admin WHERE name='" + textBox1.Text + "' AND password='" + textBox2.Text + "'";
                    OracleDataReader thisReader = thisCommand.ExecuteReader();
                    if (thisReader.Read())
                    {
                        Admin1 newForm3 = new Admin1();
                        newForm3.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("username or password incorrect");
                    }
                }
                else
                {
                    thisCommand.CommandText = "SELECT * FROM users WHERE u_name='" + textBox1.Text + "' AND password='" + textBox2.Text + "'";
                    OracleDataReader thisReader = thisCommand.ExecuteReader();
                    if (thisReader.Read())
                    {
                        Form5 newForm5 = new Form5();
                        newForm5.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("username or password incorrect");
                    }

                }
                //this.Close();
                CN.thisConnection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}

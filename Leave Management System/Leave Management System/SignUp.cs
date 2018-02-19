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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login newForm1 = new Login();
            newForm1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                connection CN = new connection();
                CN.thisConnection.Open();
               // OracleCommand thisCommand = new OracleCommand();
                OracleCommand thisCommand1 = new OracleCommand();
                thisCommand1.Connection = CN.thisConnection;
                {
                    thisCommand1.CommandText =" SELECT MAX(U_ID) FROM USERS" ;
                    int id = Convert.ToInt32(thisCommand1.ExecuteScalar());
                    id++;
                    CN.thisConnection.Close();
                    CN.thisConnection.Open();
                    OracleCommand thisCommand = new OracleCommand();
                    thisCommand.Connection = CN.thisConnection;
                    thisCommand.CommandText = "insert into users values( "+id+",'" + textBox1.Text + "','" + textBox5.Text + "','" + textBox2.Text  + "','" + textBox3.Text + "','" + textBox4.Text + "','no')";
                    OracleDataReader thisReader = thisCommand.ExecuteReader();
                    DataTable dataTable = new DataTable();
                    dataTable.Load(thisReader);

                    MessageBox.Show("Applied");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        

    }
    }
}

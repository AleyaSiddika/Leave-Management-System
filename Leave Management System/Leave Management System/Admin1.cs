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
    public partial class Admin1 : Form
    {
        public Admin1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Admin2 newForm4 = new Admin2();
            newForm4.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login newForm1 = new Login();
            newForm1.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {

                connection CN = new connection();
                CN.thisConnection.Open();
                OracleCommand thisCommand = new OracleCommand();
                thisCommand.Connection = CN.thisConnection;
                {
                    thisCommand.CommandText = "select * from users";
                    OracleDataReader thisReader = thisCommand.ExecuteReader();
                    DataTable dataTable = new DataTable();
                    dataTable.Load(thisReader);
                    dataGridView1.DataSource = dataTable;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {

                connection CN = new connection();
                CN.thisConnection.Open();
                OracleCommand thisCommand = new OracleCommand();
                thisCommand.Connection = CN.thisConnection;
                {
                    thisCommand.CommandText = "select * from applicant where status = 'yes'";
                    OracleDataReader thisReader = thisCommand.ExecuteReader();
                    DataTable dataTable = new DataTable();
                    dataTable.Load(thisReader);
                    dataGridView1.DataSource = dataTable;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            /* connection sv = new connection();
             sv.thisConnection.Open();
             OracleCommand thisCommand = sv.thisConnection.CreateCommand();

             thisCommand.CommandText =
                 "update users set status = '" + textBox2.Text + "'where u_id= '" + textBox1.Text + "'";

             thisCommand.Connection = sv.thisConnection;
             thisCommand.CommandType = CommandType.Text;
             //For Insert Data Into Oracle//
             try
             {
                 thisCommand.ExecuteNonQuery();
                 MessageBox.Show("Updated");

             }
             catch (Exception ex)
             {
                 Console.WriteLine(ex.Message);
             }

             sv.thisConnection.Close();
            */


        }
    }
}

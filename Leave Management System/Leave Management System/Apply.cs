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
    public partial class Apply : Form
    {
        public Apply()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 newForm5 = new Form5();
            newForm5.Show();
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
                {
                    
                    thisCommand.CommandText = "insert into applicant values( '" + Int32.Parse(textBox1.Text) + "','" + textBox2.Text + "','" + dateTimePicker1.Value.ToString("dd/MM/yyyy") + "','" + dateTimePicker2.Value.ToString("dd/MM/yyyy") + "','no')";
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

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
             
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
/*
            try
            {

                connection CN = new connection();
                CN.thisConnection.Open();
                OracleCommand thisCommand = new OracleCommand();
                thisCommand.Connection = CN.thisConnection;
                {

                    thisCommand.CommandText = "select u_name form users where u_id ='"+textBox1.Text+"'";

                    textBox2.Text = Convert.ToString(thisCommand.ExecuteScalar());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }*/
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            try
            {

                connection CN = new connection();
                CN.thisConnection.Open();
                OracleCommand thisCommand = new OracleCommand();
                thisCommand.Connection = CN.thisConnection;
                {

                    thisCommand.CommandText = "select u_name from users where u_id ='" + textBox1.Text + "'";

                    textBox2.Text = Convert.ToString(thisCommand.ExecuteScalar());
                    CN.thisConnection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}

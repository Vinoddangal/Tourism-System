using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Tourisim_System
{
    public partial class Form6 : Form
    {
        static MySqlConnection conn = new MySqlConnection("server=localhost;database=tourism_system;userid=root;");
        static MySqlCommand cmd = new MySqlCommand("", conn);
        public Form6()
        {
            InitializeComponent();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            login l1 = new login();
            l1.ShowDialog();
        }

        private void save_continue_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Empty Name Not Allowed!!");
                textBox1.Focus();
                return;
            }
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Empty Age Not Allowed!!");
                textBox1.Focus();
                return;
            }
            if (string.IsNullOrEmpty(comboBox1.Text))
            {
                MessageBox.Show("Empty Tourist Type Not Allowed!!");
                textBox1.Focus();
                return;
            }
            if (string.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("Empty Address Not Allowed!!");
                textBox1.Focus();
                return;
            }
            if (string.IsNullOrEmpty(textBox5.Text))
            {
                MessageBox.Show("Empty Contact Number Not Allowed!!");
                textBox1.Focus();
                return;
            }
            if (string.IsNullOrEmpty(textBox6.Text))
            {
                MessageBox.Show("Empty E-mail Not Allowed!!");
                textBox1.Focus();
                return;
            }

            try
            {
                conn.Open();
                cmd = new MySqlCommand("insert into viewinfo (`name`, `age`, `tourist_type`, `address`, `contact_number`, `e-mail`) values('" + textBox1.Text + "','" +
                    textBox2.Text + "','" + comboBox1.Text + "','" + textBox3.Text + "','" + textBox5.Text + "' , '" + textBox6.Text + "')", conn);
                cmd.ExecuteNonQuery();
               // MessageBox.Show("Save successfully");
                textBox1.Text = "";
                textBox2.Text = "";
                comboBox1.Text = "";
                textBox3.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
            this.Hide();
            Form4 f4 = new Form4();
            f4.ShowDialog();
        }
    }
}
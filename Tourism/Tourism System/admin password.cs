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
    public partial class Form3 : Form
    {
        static MySqlConnection conn = new MySqlConnection("server=localhost;database=tourism_system;userid=root;");
        static MySqlCommand cmd = new MySqlCommand("", conn);
        public Form3()
        {
            InitializeComponent();
            password.UseSystemPasswordChar = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            login f2 = new login();
            f2.ShowDialog();
        }
        private void login_Click(object sender, EventArgs e)
            {
                try
                {
                    int c = 0;
                    conn.Open();
                    cmd.CommandText = "select * from loginsystem ";
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                if ( password.Text == reader["Password"].ToString())
                                {
                                    this.Hide();
                                    Form5 f5 = new Form5();
                                    f5.ShowDialog();
                                    c++;
                                }
                            }
                        }
                        if (c == 0)
                        {
                            MessageBox.Show("Password incorrect!!");
                        }
                    }
                    conn.Close();
                }

                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.StackTrace, ex.ErrorCode.ToString());
                }
                finally
                {
                    if (conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                    }
                }
        }

        private void Show_Hide_CheckedChanged(object sender, EventArgs e)
        {
            if (Show_Hide.Checked)
            {
                password.UseSystemPasswordChar = false;

            }
            else
            {
                password.UseSystemPasswordChar = true;
            }
        }
    }
}

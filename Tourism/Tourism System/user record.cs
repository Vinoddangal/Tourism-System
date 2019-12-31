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
    public partial class Form5 : Form
    {
        static MySqlConnection conn = new MySqlConnection("server=localhost;database=tourism_system;userid=root;");
        static MySqlCommand cmd = new MySqlCommand("", conn);
        public Form5()
        {
            InitializeComponent();
        }

       

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }
       
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                cmd = new MySqlCommand("insert into international (`passport_number`, `name`, `age`, `nationality`, `contact_number`, `e-mail`) values('" + textBox1.Text + "','" +
                    textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "' , '" + textBox6.Text + "')",conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Save successfully");

                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if(conn.State==ConnectionState.Open)
                conn.Close();
                LoadData();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                cmd = new MySqlCommand("insert into national (`citizenship_number`, `name`, `age`, `address`, `contact_number`, `e-mail`) values('" + citizenship.Text + "','" +
                    textBox11.Text + "','" + textBox10.Text + "','" + textBox9.Text + "','" + textBox8.Text + "' , '" + textBox7.Text + "')", conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Save successfully");


                citizenship.Text = "";
                textBox11.Text = "";
                textBox10.Text = "";
                textBox9.Text = "";
                textBox8.Text = "";
                textBox7.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                LoadData1();
            }
        }
        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                cmd = new MySqlCommand("DELETE FROM `international` WHERE passport_number='" + textBox16.Text + "';",conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Delete successfully");
                textBox16.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();

                LoadData();
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                cmd = new MySqlCommand("delete from national where citizenship_number='" + textBox17.Text + "';", conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Delete successfully");
                textBox17.Text = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                LoadData1();
            }
        }

        private void search_international_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                cmd = new MySqlCommand("SELECT * FROM `international` WHERE passport_number=" + textBox13.Text + ";", conn);
                cmd.ExecuteNonQuery();
                MySqlDataReader reader = cmd.ExecuteReader();



                if (reader.Read())
                {
                    textBox24.Text = reader.GetString("passport_number");
                    textBox23.Text = reader.GetString("name");
                    textBox22.Text = reader.GetString("age");
                    textBox21.Text = reader.GetString("nationality");
                    textBox20.Text = reader.GetString("contact_number");
                    textBox19.Text = reader.GetString("e-mail");

                    MessageBox.Show("Search successfully");
                }
                else
                    MessageBox.Show("Search Unsuccesful");

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
        }

        private void search_natioal_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                cmd = new MySqlCommand("SELECT * FROM `national` WHERE citizenship_number=" + textBox15.Text + ";", conn);
                cmd.ExecuteNonQuery();
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    textBox25.Text = reader.GetString("citizenship_number");
                    textBox29.Text = reader.GetString("name");
                    textBox28.Text = reader.GetString("age");
                    textBox26.Text = reader.GetString("address");
                    textBox27.Text = reader.GetString("contact_number");
                    textBox18.Text = reader.GetString("e-mail");
                    MessageBox.Show("search successfully");
                }
                else
                MessageBox.Show("Search Unsuccesful");
                textBox15.Text = "";
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
        }

        private void edit_international_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                cmd = new MySqlCommand("SELECT * FROM `international` WHERE passport_number=" + textBox12.Text + ";", conn);
                cmd.ExecuteNonQuery();
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    textBox35.Text = reader.GetString("passport_number");
                    textBox34.Text = reader.GetString("name");
                    textBox33.Text = reader.GetString("age");
                    textBox32.Text = reader.GetString("nationality");
                    textBox31.Text = reader.GetString("contact_number");
                    textBox30.Text = reader.GetString("e-mail");
                }
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
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                cmd = new MySqlCommand("UPDATE `international` SET `name`= \""+textBox34.Text+"\",`age`="+textBox33.Text+",`nationality`=\""+textBox32.Text+"\",`contact_number`="+textBox31.Text+",`e-mail`=\""+textBox30.Text+"\" WHERE `passport_number`="+textBox35.Text+";", conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("update successfully");
                textBox12.Text = "";
                textBox35.Text = "";
                textBox34.Text = "";
                textBox33.Text = "";
                textBox32.Text = "";
                textBox31.Text = "";
                textBox30.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                LoadData();
            }
        }

        private void edit_national_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                cmd = new MySqlCommand("SELECT * FROM `national` WHERE citizenship_number=" + textBox14.Text + ";", conn);
                cmd.ExecuteNonQuery();
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    textBox37.Text = reader.GetString("citizenship_number");
                    textBox41.Text = reader.GetString("name");
                    textBox40.Text = reader.GetString("age");
                    textBox38.Text = reader.GetString("address");
                    textBox39.Text = reader.GetString("contact_number");
                    textBox36.Text = reader.GetString("e-mail");
                }
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
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                cmd = new MySqlCommand("UPDATE `national` SET `name`= \"" + textBox41.Text + "\",`age`=" + textBox40.Text + ",`address`=\"" + textBox38.Text + "\",`contact_number`=" + textBox39.Text + ",`e-mail`=\"" + textBox36.Text + "\" WHERE `citizenship_number`=" + textBox37.Text + ";", conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("update successfully");
                textBox14.Text = "";
                textBox37.Text = "";
                textBox41.Text = "";
                textBox40.Text = "";
                textBox38.Text = "";
                textBox39.Text = "";
                textBox36.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();

                LoadData1();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = view_info;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = user;
        }

        private void LoadData()
        {
            international_view.Rows.Clear();
            using (conn)
            {
                using (MySqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT * from international";
                    cmd.CommandType = CommandType.Text;

                    conn.Open();
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                international_view.Rows.Add(reader["passport_number"], reader["name"], reader["age"],reader["nationality"],reader["contact_number"],reader["e-mail"]);
                            }
                        }
                    }
                }
            }
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadData1();
            LoadData2();
        }
        private void LoadData1()
        {
            national_view.Rows.Clear();
            using (conn)
            {
                using (MySqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT * from national";
                    cmd.CommandType = CommandType.Text;

                    conn.Open();
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                national_view.Rows.Add(reader["citizenship_number"], reader["name"], reader["age"], reader["address"], reader["contact_number"], reader["e-mail"]);
                            }
                        }
                    }
                    conn.Close();
                }
            }
        }
        private void LoadData2()
        {
            user_view.Rows.Clear();
            using (conn)
            {
                using (MySqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT * from viewinfo";
                    cmd.CommandType = CommandType.Text;

                    conn.Open();
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                user_view.Rows.Add(reader["name"], reader["age"], reader["tourist_type"], reader["address"], reader["contact_number"], reader["e-mail"]);
                            }
                        }
                    }
                    conn.Close();
                }
            }
        }
        private void delete_international_Selected(object sender, TabControlEventArgs e)
        {
            LoadData();
        }

        private void tabControl2_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData1();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            textBox12.Text = "";
            textBox35.Text = "";
            textBox34.Text = "";
            textBox33.Text = "";
            textBox32.Text = "";
            textBox31.Text = "";
            textBox30.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox13.Text = "";
            textBox24.Text = "";
            textBox23.Text = "";
            textBox22.Text = "";
            textBox21.Text = "";
            textBox20.Text = "";
            textBox19.Text = "";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox14.Text = "";
            textBox37.Text = "";
            textBox41.Text = "";
            textBox40.Text = "";
            textBox38.Text = "";
            textBox39.Text = "";
            textBox36.Text = "";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox15.Text = "";
            textBox25.Text = "";
            textBox29.Text = "";
            textBox28.Text = "";
            textBox26.Text = "";
            textBox27.Text = "";
            textBox18.Text = "";
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = setting;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
             //   cmd = new MySqlCommand("UPDATE `loginsystem` SET `password`='" + txtnpassword.Text + "' WHERE password='" + txtcpassword.Text + "'", conn);
                string password = txtcpassword.Text;
                if(txtcpassword.Text==password)
                {
                    cmd = new MySqlCommand("UPDATE `loginsystem` SET `password`='" + txtnpassword.Text + "' WHERE password='" + txtcpassword.Text + "'", conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("update successfully");
                    txtcpassword.Text = "";
                    txtnpassword.Text = "";
                }
                else
                {
                    MessageBox.Show("Incorrect password");
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                LoadData();
            }
        }
    } 
}

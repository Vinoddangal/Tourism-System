using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Tourisim_System
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            login f2 = new login();
            f2.ShowDialog();
        }

        private void login_Click(object sender, EventArgs e)
        {
            
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
        private void tabPage6_Click(object sender, EventArgs e)
        {
            this.Hide();
            login f2 = new login();
            f2.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            login f2 = new login();
            f2.ShowDialog();
        }

        private void search_Click(object sender, EventArgs e)
        {
            string place = txtplace.Text;
            StringBuilder add = new StringBuilder("https://maps.google.com/maps?q=");
            add.Append(txtplace);
            webBrowser1.Navigate(add.ToString());
            //string latitude = "50.052282";
            //string longitude = "14.462447";
            //string url = "http://maps.google.com/maps?q=" + latitude + "," + longitude;
            //webBrowser1.Navigate(url, null, null, "User-Agent: howtofix.pro rullz!");

        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_city_Click(object sender, EventArgs e)
        {

        }

       
        

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {   // Open the text file using a stream reader.
                using (StreamReader sr = new StreamReader("c:\\Users\\Binod Dangal\\Documents\\tourismsystem\\Pashupati.txt"))
                {
                    // Read the stream to a string, and write the string to the console.
                    String line = sr.ReadToEnd();
                    richTextBox1.Text = "";
                    richTextBox1.Text = line;
                }
            }
            catch (Exception exp)
            {
                //.WriteLine("The file could not be read:");
                MessageBox.Show(exp.Message);
            }
            pictureBox3.Image = global::Tourisim_System.Properties.Resources.pashupati1;
            pictureBox4.Image = global::Tourisim_System.Properties.Resources.Pashupati2;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {   // Open the text file using a stream reader.
                using (StreamReader sr = new StreamReader("c:\\Users\\Binod Dangal\\Documents\\tourismsystem\\boudha.txt"))
                {
                    // Read the stream to a string, and write the string to the console.
                    String line = sr.ReadToEnd();
                    richTextBox1.Text = "";
                    richTextBox1.Text = line;
                }
            }
            catch (Exception exp)
            {
                //.WriteLine("The file could not be read:");
                MessageBox.Show(exp.Message);
            }
            pictureBox3.Image = global::Tourisim_System.Properties.Resources.bauddha1;
            pictureBox4.Image = global::Tourisim_System.Properties.Resources.boudha2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {   // Open the text file using a stream reader.
                using (StreamReader sr = new StreamReader("c:\\Users\\Binod Dangal\\Documents\\tourismsystem\\pokhara.txt"))
                {
                    // Read the stream to a string, and write the string to the console.
                    String line = sr.ReadToEnd();
                    richTextBox1.Text = "";
                    richTextBox1.Text = line;
                }
            }
            catch (Exception exp)
            {
                //.WriteLine("The file could not be read:");
                MessageBox.Show(exp.Message);
            }
            pictureBox3.Image = global::Tourisim_System.Properties.Resources.pokhara1;
            pictureBox4.Image = global::Tourisim_System.Properties.Resources.pokhara2;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {   // Open the text file using a stream reader.
                using (StreamReader sr = new StreamReader("c:\\Users\\Binod Dangal\\Documents\\tourismsystem\\chitwan.txt"))
                {
                    // Read the stream to a string, and write the string to the console.
                    String line = sr.ReadToEnd();
                    richTextBox1.Text = "";
                    richTextBox1.Text = line;
                }
            }
            catch (Exception exp)
            {
                //.WriteLine("The file could not be read:");
                MessageBox.Show(exp.Message);
            }
            pictureBox3.Image = global::Tourisim_System.Properties.Resources.chitwan1;
            pictureBox4.Image = global::Tourisim_System.Properties.Resources.chitwan2;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {   // Open the text file using a stream reader.
                using (StreamReader sr = new StreamReader("c:\\Users\\Binod Dangal\\Documents\\tourismsystem\\lumbini.txt"))
                {
                    // Read the stream to a string, and write the string to the console.
                    String line = sr.ReadToEnd();
                    richTextBox1.Text = "";
                    richTextBox1.Text = line;
                }
            }
            catch (Exception exp)
            {
                //.WriteLine("The file could not be read:");
                MessageBox.Show(exp.Message);
            }
            pictureBox3.Image = global::Tourisim_System.Properties.Resources.lumbibi1;
            pictureBox4.Image = global::Tourisim_System.Properties.Resources.lumbibi2;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {   // Open the text file using a stream reader.
                using (StreamReader sr = new StreamReader("c:\\Users\\Binod Dangal\\Documents\\tourismsystem\\mustang.txt"))
                {
                    // Read the stream to a string, and write the string to the console.
                    String line = sr.ReadToEnd();
                    richTextBox1.Text = "";
                    richTextBox1.Text = line;
                }
            }
            catch (Exception exp)
            {
                //.WriteLine("The file could not be read:");
                MessageBox.Show(exp.Message);
            }
            pictureBox3.Image = global::Tourisim_System.Properties.Resources.mustang1;
             pictureBox4.Image = global::Tourisim_System.Properties.Resources.mustang2;
        }

        private void exit(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void everest_Click(object sender, EventArgs e)
        {
            try
            {   // Open the text file using a stream reader.
                using (StreamReader sr = new StreamReader("c:\\Users\\Binod Dangal\\Documents\\tourismsystem\\everest.txt"))
                {
                    // Read the stream to a string, and write the string to the console.
                    String line = sr.ReadToEnd();
                    richTextBox1.Text = "";
                    richTextBox1.Text = line;
                }
            }
            catch (Exception exp)
            {
                //.WriteLine("The file could not be read:");
                MessageBox.Show(exp.Message);
            }
            pictureBox3.Image = global::Tourisim_System.Properties.Resources.everest1;
            pictureBox4.Image = global::Tourisim_System.Properties.Resources.everest2;
        }

        private void rara_Click(object sender, EventArgs e)
        {
            try
            {   // Open the text file using a stream reader.
                using (StreamReader sr = new StreamReader("c:\\Users\\Binod Dangal\\Documents\\tourismsystem\\rara.txt"))
                {
                    // Read the stream to a string, and write the string to the console.
                    String line = sr.ReadToEnd();
                    richTextBox1.Text = "";
                    richTextBox1.Text = line;
                }
            }
            catch (Exception exp)
            {
                //.WriteLine("The file could not be read:");
                MessageBox.Show(exp.Message);
            }
            pictureBox3.Image = global::Tourisim_System.Properties.Resources.rara1;
            pictureBox4.Image = global::Tourisim_System.Properties.Resources.rara2;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            webBrowser1.ScriptErrorsSuppressed = true;
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            MessageBox.Show(" Registered Date: 2064-03-01 \n Contact Address: Lal Durbar, Kathmandu \n Phone no.: 01 - 4430188 \n Email add: sales@nta.com.np");
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Registered Date: 2064-03-01 \nContact Address: Gangapath, Kathmandu \nPhone no.: 01 - 4222217 \nEmail add: everest@ets.com.np");
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Registered Date: 2065-02-03 \nContact Address: Durbar Marg, Kathmandu \nPhone no.: 01 - 4221234 \nEmail add: yeti@yetitravels.com.np");
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Registered Date: 2062-11-30 \nContact Address: Durbar Marg, Kathmandu \nPhone no.: 01 - 4223530 \nEmail add: navraj@mos.com.np");
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Registered Date: 2065-01-09 \nContact Address: Kamalpokhari, Kathmandu \nPhone no.: 01 - 4440761 \nEmail add: info@gorkhatravels.com");
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Registered Date: 2063-07-25 \nContact Address: Lazimpat, Kathmandu \nPhone no.: 01 - 4411465 \nEmail add: shantrvl@ntc.net.np");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Registered Date: 2063-08-24 \nContact Address: Battisputali, Kathmandu \nPhone no.: 01 - 4471577 \nEmail add: info@kttgroup.com");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Registered Date: 2064-04-19 \nContact Address: Darbarmarg, Kathmandu \nPhone no.: 01 - 4223045 \nEmail add: htt@ecomail.com.np");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Registered Date: 2062-09-03 \nContact Address: Kopundol, Lalitpur \nPhone no.: 01 - 5011647 \nEmail add: ththev@mos.com.np");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Registered Date: 2063-11-15 \nContact Address: Kamaladi, Kathmandu \nPhone no.: 01 - 4220001 \nEmail add: natraj@ccsl.com.np");
        }

        private void agency_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {   // Open the text file using a stream reader.
                using (StreamReader sr = new StreamReader("c:\\Users\\Binod Dangal\\Documents\\tourismsystem\\bunjyjump.txt"))
                {
                    // Read the stream to a string, and write the string to the console.
                    String line = sr.ReadToEnd();
                    richTextBox2.Text = "";
                    richTextBox2.Text = line;
                }
            }
            catch (Exception exp)
            {
                //.WriteLine("The file could not be read:");
                MessageBox.Show(exp.Message);
            }
            pictureBox5.Image = global::Tourisim_System.Properties.Resources.bunjee;
            pictureBox6.Image = global::Tourisim_System.Properties.Resources.Bungy_1;
        }

        private void bungyswing_Click(object sender, EventArgs e)
        {
            try
            {   // Open the text file using a stream reader.
                using (StreamReader sr = new StreamReader("c:\\Users\\Binod Dangal\\Documents\\tourismsystem\\rafting.txt"))
                {
                    // Read the stream to a string, and write the string to the console.
                    String line = sr.ReadToEnd();
                    richTextBox2.Text = "";
                    richTextBox2.Text = line;
                }
            }
            catch (Exception exp)
            {
                //.WriteLine("The file could not be read:");
                MessageBox.Show(exp.Message);
            }
            pictureBox5.Image = global::Tourisim_System.Properties.Resources.rafting1;
            pictureBox6.Image = global::Tourisim_System.Properties.Resources.rafting2;
        }

        private void paragliding_Click(object sender, EventArgs e)
        {
            try
            {   // Open the text file using a stream reader.
                using (StreamReader sr = new StreamReader("c:\\Users\\Binod Dangal\\Documents\\tourismsystem\\paragliding.txt"))
                {
                    // Read the stream to a string, and write the string to the console.
                    String line = sr.ReadToEnd();
                    richTextBox2.Text = "";
                    richTextBox2.Text = line;
                }
            }
            catch (Exception exp)
            {
                //.WriteLine("The file could not be read:");
                MessageBox.Show(exp.Message);
            }
            pictureBox5.Image = global::Tourisim_System.Properties.Resources.paragliding1;
            pictureBox6.Image = global::Tourisim_System.Properties.Resources.Paragliding2;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            try
            {   // Open the text file using a stream reader.
                using (StreamReader sr = new StreamReader("c:\\Users\\Binod Dangal\\Documents\\tourismsystem\\zipflyingnepal.txt"))
                {
                    // Read the stream to a string, and write the string to the console.
                    String line = sr.ReadToEnd();
                    richTextBox2.Text = "";
                    richTextBox2.Text = line;
                }
            }
            catch (Exception exp)
            {
                //.WriteLine("The file could not be read:");
                MessageBox.Show(exp.Message);
            }
            pictureBox5.Image = global::Tourisim_System.Properties.Resources.zip_flyer_Nepal1;
            pictureBox6.Image = global::Tourisim_System.Properties.Resources.zip_flyer_nepal2;
        }

        private void canyoning_Click(object sender, EventArgs e)
        {
            try
            {   // Open the text file using a stream reader.
                using (StreamReader sr = new StreamReader("c:\\Users\\Binod Dangal\\Documents\\tourismsystem\\canyoning.txt"))
                {
                    // Read the stream to a string, and write the string to the console.
                    String line = sr.ReadToEnd();
                    richTextBox2.Text = "";
                    richTextBox2.Text = line;
                }
            }
            catch (Exception exp)
            {
                //.WriteLine("The file could not be read:");
                MessageBox.Show(exp.Message);
            }
            pictureBox5.Image = global::Tourisim_System.Properties.Resources.canyoning1;
            pictureBox6.Image = global::Tourisim_System.Properties.Resources.canyoning2;
        }
    }
}

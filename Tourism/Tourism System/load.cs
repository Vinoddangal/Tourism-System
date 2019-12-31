using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tourisim_System
{
   
    public partial class NTS : Form
    {
        private int _ticks;
        public NTS()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            _ticks++;
           // this.Text = _ticks.ToString();

            if (_ticks==5)
            {
                timer1.Stop();
                this.Hide();
                login f2 = new login();
                f2.ShowDialog();
            }
        }
    }
}

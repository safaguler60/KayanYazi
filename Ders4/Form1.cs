using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString();
            label2.Left = label2.Left - 1;
           
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            label1.BackColor = Color.Red;
            label2.ForeColor = Color.Red;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Start();
            label1.BackColor = Color.LightGreen;
            label2.ForeColor = Color.LightGreen;
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}

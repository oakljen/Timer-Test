using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }
        public int seconds = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            seconds++;
            label1.Text = $"Timer : {seconds / 60:00}:{seconds % 60:00}";
        }

        private void timer_starter_Click(object sender, EventArgs e)
        {
            seconds = 0;
            timer1.Start();
        }

        private void stop_timer_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }
}

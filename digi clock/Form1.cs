using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace digi_clock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            daytime.Text = DateTime.Now.ToString("HH:mm");
            secs.Text = DateTime.Now.ToString("ss");
            date.Text = DateTime.Now.ToString("MMM dd yyyy");
            week.Text = DateTime.Now.ToString("dddd");
            
        }

        private void daytime_Click(object sender, EventArgs e)
        {

        }

        private void date_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void daytime_DoubleClick(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DotNET_countdown
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(188, 0, 0, 0);//sets the transparency rate for the panel(RGB Color)
        }
       
        DateTime endTime = new DateTime(2018, 10, 07, 6, 30, 0); //date & time of the event

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan ts = endTime.Subtract(DateTime.Now);//sets a variable to substract the current date & time with the one provided in the variable endtime
            
            label1.Text = ts.Days.ToString() + " Days";
            label2.Text = ts.Hours.ToString() + " Hours";
            label3.Text = ts.Minutes.ToString() + " Minutes";
            label4.Text = ts.Seconds.ToString() + " Seconds";

            //alarms the user if there's 5 hours left
            if (label1.Text == "0 Days" && label2.Text == "5 Hours" && label3.Text == "0 Minutes" && label4.Text == "0 Seconds")
            {
                MessageBox.Show("ONLY 5 HOURS LEFT UNTIL THE CONFERENCE BEGIN!", "URGENT!");
            }

            //alarms the user if there's less than 1 day left
            if (label1.Text == "0 Days")
            {
                MessageBox.Show("LESS THAN 1 DAY LEFT UNTIL THE CONFERENCE BEGIN!", "URGENT!");
            }
           //alarms the user if there's 30 mins left
            if (label1.Text == "0 Days" && label2.Text == "0 Hours" && label3.Text == "30 Minutes" && label4.Text == "0 Seconds")
            {
                MessageBox.Show("ONLY 30 MINS LEFT UNTIL THE CONFERENCE BEGIN!", "URGENT!");
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}

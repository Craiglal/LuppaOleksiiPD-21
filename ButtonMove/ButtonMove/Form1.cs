using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ButtonMove
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            int oreal = 20;
            if ((e.X >= bt_no.Left - oreal) && (e.Y >= bt_no.Top - oreal) && (e.X <= bt_no.Left) && (e.Y <= bt_no.Top))
            {
                bt_no.Left = bt_no.Left + 5;
                bt_no.Top = bt_no.Top + 5;
                bt_no.Width -= 1;
                bt_no.Height -= 1;
            }
            else if ((e.Y >= bt_no.Top - oreal) && (e.Y <= bt_no.Top) && (e.X <= bt_no.Right) && (e.X >= bt_no.Left))
            {
                bt_no.Top = bt_no.Top + 5;
                bt_no.Width -= 1;
                bt_no.Height -= 1;
            }
            else if ((e.X >= bt_no.Left + bt_no.Width) && (e.Y >= bt_no.Top - oreal) && (e.X <= bt_no.Left + bt_no.Width + oreal) && (e.Y <= bt_no.Top))
            {
                bt_no.Left = bt_no.Left - 5;
                bt_no.Top = bt_no.Top + 5;
                bt_no.Width -= 1;
                bt_no.Height -= 1;
            }
            else if ((e.X >= bt_no.Left + bt_no.Width) && (e.X <= bt_no.Left + bt_no.Width + oreal) && (e.Y <= bt_no.Bottom) && (e.Y >= bt_no.Top))
            {
                bt_no.Left = bt_no.Left - 5;
                bt_no.Width -= 1;
                bt_no.Height -= 1;
            }
            else if ((e.X >= bt_no.Left + bt_no.Width) && (e.Y >= bt_no.Top + bt_no.Height) && (e.X <= bt_no.Left + bt_no.Width + oreal) && (e.Y <= bt_no.Top + bt_no.Height + oreal))
            {
                bt_no.Left = bt_no.Left - 5;
                bt_no.Top = bt_no.Top - 5;
                bt_no.Width -= 1;
                bt_no.Height -= 1;
            }
            else if ((e.Y >= bt_no.Top + bt_no.Height) && (e.Y <= bt_no.Top + bt_no.Height + oreal) && (e.X <= bt_no.Right) && (e.X >= bt_no.Left))
            {
                bt_no.Top = bt_no.Top - 5;
                bt_no.Width -= 1;
                bt_no.Height -= 1;
            }
            else if ((e.X >= bt_no.Left - oreal) && (e.Y >= bt_no.Top + bt_no.Height) && (e.X <= bt_no.Left) && (e.Y <= bt_no.Top + bt_no.Height + oreal))
            {
                bt_no.Left = bt_no.Left + 5;
                bt_no.Top = bt_no.Top - 5;
                bt_no.Width -= 1;
                bt_no.Height -= 1;
            }
            else if ((e.X >= bt_no.Left - oreal) && (e.X <= bt_no.Left) && (e.Y <= bt_no.Bottom) && (e.Y >= bt_no.Top))
            {
                bt_no.Left = bt_no.Left + 5;
                bt_no.Width -= 1;
                bt_no.Height -= 1;
            }

            if (bt_no.Left < 0)
                bt_no.Left = 100;

            if ((bt_no.Left + bt_no.Width) > this.ClientSize.Width)
                bt_no.Left = this.ClientSize.Width - bt_no.Width - 100; 

            if (bt_no.Top < 0)
                bt_no.Top = 100;

            if ((bt_no.Top + bt_no.Height) > this.ClientSize.Height)
                bt_no.Top = this.ClientSize.Height - bt_no.Height - 100;

            Random r = new Random();
            if(e.X >= bt_no.Left && e.Y >= bt_no.Top && e.X <= bt_no.Right && e.Y <= bt_no.Bottom)
            {
                bt_no.Left = r.Next(0, this.ClientSize.Width - bt_no.Width);
                bt_no.Top = r.Next(0, this.ClientSize.Height - bt_no.Height);
            }

            if (bt_no.Width <= 0)
                Text = "No 'No' button!";
        }

        private void bt_yes_Click(object sender, EventArgs e)
        {
            MessageBox.Show("U lose!");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Text = "Click button 'NO'";
            timer1.Enabled = false;
            timer2.Enabled = true;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Text = "";
            timer1.Enabled = true;
            timer2.Enabled = false;
        }
    }
}

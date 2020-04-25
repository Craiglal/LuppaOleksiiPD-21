using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TikTacToe
{
    public partial class Form1 : Form
    {
        public int player;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            player = 0;
            Form2 childForm = new Form2(player, this);
            childForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            player = 1;
            Form2 childForm = new Form2(player, this);
            childForm.ShowDialog();
        }
    }
}

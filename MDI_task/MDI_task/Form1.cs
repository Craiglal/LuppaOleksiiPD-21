using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDI_task
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            List<string> nameChanger = new List<string>() {
                "Increment Num",
                "Decrement Num",
                "Same Num"
            };
            comboBox1.DataSource = nameChanger;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Form child = new Form();
            if(comboBox1.SelectedItem == comboBox1.Items[0])
            {
                textBox2.Text = (Convert.ToInt32(textBox2.Text) + 1).ToString();
            }
            else if(comboBox1.SelectedItem == comboBox1.Items[1])
            {
                textBox2.Text = (Convert.ToInt32(textBox2.Text) - 1).ToString();
            }
            child.Text = textBox1.Text + " " + textBox2.Text;
            child.Location = new Point(188, 30);
            child.MdiParent = this;
            toolStrip1.Items[1].Text = (Convert.ToInt32(toolStrip1.Items[1].Text) + 1).ToString();
            if(toolStripProgressBar1.Value == 10)
                toolStripProgressBar1.Value = 1;
            else
                toolStripProgressBar1.Value += 1;
            child.Show();
        }
    }
}

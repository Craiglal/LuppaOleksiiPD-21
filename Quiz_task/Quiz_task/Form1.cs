using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz_task
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Hide();
            button2.Hide();
            label1.Hide();

            AddConfig();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void AddConfig()
        {
            TextBox width = new TextBox()
            {
                Location = new System.Drawing.Point(12, 12),
                Name = "width",
                Size = new System.Drawing.Size(100, 22),
                TabIndex = 0,
            };
            Controls.Add(width);
            TextBox height = new TextBox()
            {
                Location = new System.Drawing.Point(12, 40),
                Name = "height",
                Size = new System.Drawing.Size(100, 22),
                TabIndex = 0,
            };
            Controls.Add(height);

            Label widthlbl = new Label()
            {
                AutoSize = true,
                Location = new System.Drawing.Point(119, 16),
                Name = "widthlbl",
                Size = new System.Drawing.Size(59, 17),
                TabIndex = 2,
                Text = "Ширина",
            };
            Controls.Add(widthlbl);
            Label heightlbl = new Label()
            {
                AutoSize = true,
                Location = new System.Drawing.Point(119, 43),
                Name = "widthlbl",
                Size = new System.Drawing.Size(55, 17),
                TabIndex = 2,
                Text = "Висота",
            };
            Controls.Add(heightlbl);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_xx_Sem_2
{
    public partial class Form2 : Form
    {
        public Form2(StreamReader reader)
        {
            InitializeComponent();

            richTextBox1.Text = reader.ReadToEnd();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Curves_task
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            int offset = 1;
            for (int j = 0; j < chart1.Series.Count; j++)
            {
                for (double i = 1; i <= 40; i+=0.1)
                    chart1.Series[j].Points.AddXY(i, Math.Sin(i * (j + 1)) + offset);
                offset+=5;
            }
        }
    }
}

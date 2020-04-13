using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_3_Sem_2
{
    public partial class Form1 : Form
    {
        private int current { get; set; } = 1;
        public Form1()
        {
            InitializeComponent();
            
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Name";
        }

        void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Btn phone = (Btn)comboBox1.SelectedItem;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != null)
                comboBox1.Items.Add(new Btn(textBox1.Text));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Btn phone = (Btn)comboBox1.SelectedItem;
            if (phone != null)
            {
                comboBox1.Items.Remove(phone);
                comboBox1.Text = ""; 
            }
        }

        private void buttonQuiz_Click(object sender, EventArgs e)
        {
            Button curBtn = (Button)sender;
            if (Convert.ToInt32(curBtn.Text) == current)
            {
                current++;
                progressBar1.Value += 1;
                this.tabPage2.Controls.Remove((Button)sender);
                IEnumerable<Control> buttonArr = from Control control in tabPage2.Controls
                                                 where control.GetType().ToString().Contains("Button")
                                                 select control;
                var rnd = new Random(DateTime.Now.Millisecond);
                var coordinates = buttonArr.Select(r => new Point(r.Location.X, r.Location.Y)).ToList();
                for (var j = 0; j < coordinates.Count; j++)
                {
                    var tmp = coordinates[j];
                    coordinates.Remove(coordinates[j]);
                    coordinates.Insert(rnd.Next(coordinates.Count), tmp);
                }
                int i = 0;
                foreach (Button btn in buttonArr)
                    btn.Location = coordinates[i++];
            }
            else
            {
                current = 1;
                progressBar1.Value = 0;
                IEnumerable<Control> buttonArr = from Control control in tabPage2.Controls
                                                 where control.GetType().ToString().Contains("Button")
                                                 select control;
                foreach(Button btn in buttonArr)
                {
                    this.tabPage2.Controls.Remove(btn);
                }
                addQuizBtns();
            }
        }

        public void addQuizBtns()
        {
            List<Button> buttons = new List<Button>();
            int cnt = 1;
            for (int i = 0; i < 16; i++)
            {
                buttons.Add(new Button());
                buttons[i].Name = $"Btn.{cnt++}";
                buttons[i].Size = new Size(100, 20);
                buttons[i].Click += new EventHandler(this.buttonQuiz_Click);
                buttons[i].Text = (i + 1).ToString();
                buttons[i].TabIndex = 0;
            }
            Random rnd = new Random();
            int max = 16;
            var temp = buttons;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    var btn = temp[rnd.Next(max--)];
                    temp.Remove(btn);

                    btn.Location = new Point(100 * i + 130, 20 * j + 130);
                    this.tabPage2.Controls.Add(btn);
                }
            }
        }
    }
}

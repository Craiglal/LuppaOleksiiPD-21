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
    public partial class Form2 : Form
    {
        public int player;
        private Button[,] buttons;
        private string Cross;
        private string Zero;
        private Process process;
        private Form1 parentForm;

        public Form2(int _player, Form1 _parentForm)
        {
            InitializeComponent();
            parentForm = _parentForm;

            SetElements(_player);

            Build(process);
        }

        private void SetElements(int _player)
        {
            Cross = "X";
            Zero = "O";
            player = _player;
            process = new Process();
            buttons = GetButtons();
            Random rand = new Random();
            if (player == 1)
            {
                process.Step(new Point(rand.Next(0,3), rand.Next(0, 3)));
            }
        }

        private Button[,] GetButtons()
        {
            IEnumerable<Control> buttonArr = from Control control in Controls
                                             where control.GetType().ToString().Contains("Button")
                                             select control;
            Button[,] btns = new Button[3, 3];
            int k = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    btns[i, j] = (Button)buttonArr.Reverse().ToArray()[k];
                    var nae = btns[i, j].Name;
                    btns[i, j].Tag = new Point(i, j);
                    k++;
                }
            }

            return btns;
        }

        private void Build(Process game)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (game.steps[i, j] == "X")
                    {
                        buttons[i, j].Text = Cross;
                        buttons[i, j].Enabled = false;
                    }
                    else if (game.steps[i, j] == "O")
                    {
                        buttons[i, j].Text = Zero;
                        buttons[i, j].Enabled = false;
                    }
                }
            }
        }

        void button_Click(object sender, EventArgs e)
        {
            Point point = (Point)((Button)sender).Tag;
            process.Step(point);
            if (!process.Win)
            {
                Step ai = new AITicTacToe().BestStep(process);
                if (ai != null)
                    process.Step(ai.Point);
            }
            Build(process);

            if (process.Win)
            {
                if(parentForm.player == 0)
                {
                    if(process.Player == 0)
                        MessageBox.Show(string.Format("Ви виграли!"));
                    else
                        MessageBox.Show(string.Format("Ви програли!"));
                }
                else
                {
                    if (process.Player == 0)
                        MessageBox.Show(string.Format("Ви програли!"));
                    else
                        MessageBox.Show(string.Format("Ви виграли!"));
                }
                
                Button reset = new Button()
                {
                    Parent = this,
                    Size = new Size(85, 40),
                    Top = 320,
                    Left = 230,
                    Text = "Спробувати ще раз"
                };
                reset.Click += new EventHandler(restart_Click);
            }
            else
            {
                if (!(new AITicTacToe().GetFreeSteps(process).Any()))
                {
                    MessageBox.Show(string.Format("Нічия!"));
                    Button reset = new Button()
                    {
                        Parent = this,
                        Size = new Size(85, 40),
                        Top = 320,
                        Left = 230,
                        Text = "Спробувати ще раз"
                    };
                    reset.Click += new EventHandler(restart_Click);
                }
            }
        }

        private void restart_Click(object sender, EventArgs e)
        {
            parentForm.Show();
            Dispose();
            Close();
        }
        private void Form2_FormClosing(Object sender, FormClosingEventArgs e)
        {
            parentForm.Show();
            Dispose();
            Close();
        }
    }
}

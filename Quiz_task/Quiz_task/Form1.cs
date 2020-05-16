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
using System.Xml;
using System.Xml.Linq;

namespace Quiz_task
{
    public partial class Form1 : Form
    {
        const string config = "config.xml";
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
            Quiz quiz = new Quiz();
            quiz.Show();
        }

        private void AddConfig()
        {
            if (!File.Exists(config))
            {
                XmlDocument create = new XmlDocument();
                XmlNode conf = create.CreateElement("Configuration");
                XmlNode words = create.CreateElement("Words");
                XmlNode configur = create.CreateElement("Config");
                conf.AppendChild(configur);
                conf.AppendChild(words);
                create.AppendChild(conf);
                create.Save(config);

            }
            else
            {
                XmlDocument open = new XmlDocument();
                open.Load(config);
                open.ChildNodes.Item(0).ChildNodes.Item(0).RemoveAll();
                open.ChildNodes.Item(0).ChildNodes.Item(1).RemoveAll();
                open.Save(config);
            }

            Height = 300;
            Width = 620;
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

            Label x = new Label()
            {
                Location = new System.Drawing.Point(12, 68),
                Name = "x",
                Size = new System.Drawing.Size(17, 17),
                TabIndex = 2,
                Text = "X"
            };
            Controls.Add(x);

            NumericUpDown xnum = new NumericUpDown()
            {
                Location = new System.Drawing.Point(35, 68),
                Name = "xnum",
                Size = new System.Drawing.Size(50, 22)
            };
            Controls.Add(xnum);

            Label y = new Label()
            {
                Location = new System.Drawing.Point(90, 68),
                Name = "y",
                Size = new System.Drawing.Size(17, 17),
                TabIndex = 2,
                Text = "Y"
            };
            Controls.Add(y);

            NumericUpDown ynum = new NumericUpDown()
            {
                Location = new System.Drawing.Point(113, 68),
                Name = "ynum",
                Size = new System.Drawing.Size(50, 22)
            };
            Controls.Add(ynum);

            Label lengthLabel = new Label()
            {
                Location = new Point(168, 68),
                Size = new Size(60, 17),
                Text = "Довжина:"
            };
            Controls.Add(lengthLabel);

            NumericUpDown length = new NumericUpDown()
            {
                Location = new Point(234, 68),
                Maximum = 100,
                Minimum = 1,
                Width = 60
            };
            Controls.Add(length);

            Label positionLabel = new Label()
            {
                Location = new Point(299, 68),
                Size = new Size(70, 17),
                Text = "Положення:"
            };
            Controls.Add(positionLabel);

            ComboBox position = new ComboBox()
            {
                Location = new Point(375, 68),
                Height = 22,
            };

            position.Items.Add("Горизонтальне");
            position.Items.Add("Вертикальне");
            position.SelectedIndex = 0;
            Controls.Add(position);

            Button buttonAdd = new Button()
            {
                Location = new Point(520, 68),
                Text = "Додати слово",
                Height = 22,
            };

            Label newWord = new Label()
            {
                Location = new Point(12, 95),
                Size = new Size(500, 20),
                Text = $""
            };
            Controls.Add(newWord);
            buttonAdd.Click += (s, e) =>
            {
                AddToConfig(xnum.Value, ynum.Value, length.Value, position.SelectedItem);
                AddWord(length.Value);
                newWord.Text = $"Додано слово з конфігурацією: X = {xnum.Value}, Y = {ynum.Value}, Length = {length.Value}, {position.SelectedItem}";
            };
            Controls.Add(buttonAdd);

            Button confirm = new Button()
            {
                Location = new Point(270, 12),
                Text = "Підтвердити",
                Height = 40,
            };
            confirm.Click += (s, e) =>
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(config);
                XmlAttribute hght = doc.CreateAttribute("height");
                hght.AppendChild(doc.CreateTextNode(height.Text));
                XmlAttribute wdth = doc.CreateAttribute("width");
                wdth.AppendChild(doc.CreateTextNode(width.Text));
                doc.ChildNodes.Item(0).Attributes.Append(hght);
                doc.ChildNodes.Item(0).Attributes.Append(wdth);
                doc.Save(config);
                Hide();
                Quiz quiz = new Quiz();
                quiz.Show();
            };
            Controls.Add(confirm);
        }

        private void AddToConfig(decimal x, decimal y, decimal len, object pos)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(config);

            XmlElement wc = doc.CreateElement("wConf");

            XmlAttribute xXml = doc.CreateAttribute("x");
            xXml.AppendChild(doc.CreateTextNode(x.ToString()));

            XmlAttribute yXml = doc.CreateAttribute("y");
            yXml.AppendChild(doc.CreateTextNode(y.ToString()));

            XmlAttribute lengthXml = doc.CreateAttribute("length");
            lengthXml.AppendChild(doc.CreateTextNode(len.ToString()));

            XmlAttribute positionXml = doc.CreateAttribute("position");
            positionXml.AppendChild(doc.CreateTextNode(pos.ToString()));

            wc.Attributes.Append(xXml);
            wc.Attributes.Append(yXml);
            wc.Attributes.Append(lengthXml);
            wc.Attributes.Append(positionXml);

            doc.ChildNodes.Item(0).ChildNodes.Item(0).AppendChild(wc);
            doc.Save(config);
        }

        public void AddWord(decimal length)
        {
            AddWord form = new AddWord(length);
            form.Show();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Quiz_task
{
    public partial class Quiz : Form
    {
        const string config = "config.xml";
        public Quiz()
        {
            InitializeComponent();
            GenerateQuiz();
        }

        public void GenerateQuiz()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(config);
            panel1.Width = Convert.ToInt32(doc.ChildNodes.Item(0).Attributes["width"].Value);
            panel1.Height = Convert.ToInt32(doc.ChildNodes.Item(0).Attributes["height"].Value);
            AddWords();
        }

        public void AddWords()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(config);


            int widthResize = 0;
            int heightResize = 0;
            ReSize(panel1.Height, panel1.Width, out widthResize, out heightResize);
            int widthR = (Convert.ToInt32(doc.ChildNodes.Item(0).Attributes["width"].Value)
                - widthResize * 5) / widthResize;

            int heightR = (Convert.ToInt32(doc.ChildNodes.Item(0).Attributes["height"].Value)
                - heightResize * 5) / heightResize;

            for(int i = 0; i < doc.ChildNodes.Item(0).ChildNodes.Item(0).ChildNodes.Count; i++)
            {
                XmlNode el = doc.ChildNodes.Item(0).ChildNodes.Item(0).ChildNodes[i];
                if(el.Attributes["position"].Value == "Горизонтальне")
                {
                    for(int j = 0; j < Convert.ToInt32(el.Attributes["length"].Value); j++)
                    {
                        RichTextBox rtb = new RichTextBox()
                        {
                            Name = "rtb" + i + j,
                            Location = new Point(j * widthR + Convert.ToInt32(el.Attributes["x"].Value) * widthR, Convert.ToInt32(el.Attributes["y"].Value) * heightR),
                            Width = widthR,
                            Height = heightR,
                            MaxLength = 1
                        };
                        panel1.Controls.Add(rtb);
                    }
                    XmlNode wrd = doc.ChildNodes.Item(0).ChildNodes.Item(1).ChildNodes[i];
                    Label lb = new Label()
                    {
                        Location = new System.Drawing.Point(12, 12 + Convert.ToInt32(doc.ChildNodes.Item(0).Attributes["height"].Value) + 10 + i * 25),
                        Text = (i + 1) + ") " + el.Attributes["position"].Value + " " + wrd.Attributes["description"].Value,
                        Width = this.Width
                    };
                    Controls.Add(lb);
                }
                else
                {
                    for (int j = 0; j < Convert.ToInt32(el.Attributes["length"].Value); j++)
                    {
                        RichTextBox rtb = new RichTextBox()
                        {
                            Name = "rtb" + i + j,
                            Location = new Point(Convert.ToInt32(el.Attributes["x"].Value) * widthR, j * heightR + Convert.ToInt32(el.Attributes["y"].Value) * heightR),
                            Width = widthR,
                            Height = heightR,
                            MaxLength = 1
                        };
                        panel1.Controls.Add(rtb);
                    }
                    XmlNode wrd = doc.ChildNodes.Item(0).ChildNodes.Item(1).ChildNodes[i];
                    Label lb = new Label()
                    {
                        Location = new System.Drawing.Point(12, 12 + Convert.ToInt32(doc.ChildNodes.Item(0).Attributes["height"].Value) + 10 + i * 25),
                        Text = (i + 1) + ") " + el.Attributes["position"].Value + " " + wrd.Attributes["description"].Value,
                        Width = this.Width
                    };
                    Controls.Add(lb);
                }
            }
        }

        public void ReSize(int h, int w, out int widthResize, out int heightResize)
        {
            widthResize = 0;
            heightResize = 0;
            XmlDocument doc = new XmlDocument();
            doc.Load(config);
            foreach (XmlElement word in doc.ChildNodes.Item(0).ChildNodes.Item(0).ChildNodes)
             {
                int x = int.Parse(word.Attributes["x"].Value);
                int y = int.Parse(word.Attributes["y"].Value);
                int length = int.Parse(word.Attributes["length"].Value);

                if (x + length > widthResize
                    && word.Attributes["position"].Value == "Горизонтальне")
                {
                    widthResize = x + length;
                }

                if (y + length > heightResize
                    && word.Attributes["position"].Value == "Вертикальне")
                {
                    heightResize = y + length;
                }
            }
        }
    }
}

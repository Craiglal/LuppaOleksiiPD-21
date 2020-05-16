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
    public partial class AddWord : Form
    {
        const string config = "config.xml";
        public AddWord(decimal len)
        {
            InitializeComponent();

            textBox1.MaxLength = Convert.ToInt32(len);
            label2.Text = String.Format(label2.Text, len);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(config);

            XmlElement wc = doc.CreateElement("word");

            XmlAttribute word = doc.CreateAttribute("word");
            word.AppendChild(doc.CreateTextNode(textBox1.Text));

            XmlAttribute desc = doc.CreateAttribute("description");
            desc.AppendChild(doc.CreateTextNode(richTextBox1.Text));

            wc.Attributes.Append(word);
            wc.Attributes.Append(desc);

            doc.ChildNodes.Item(0).ChildNodes.Item(1).AppendChild(wc);
            doc.Save(config);

            Close();
        }
    }
}

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
    public partial class Form1 : Form
    {
        private string path = @"C:\Folders";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 100; i++)
                Directory.CreateDirectory(path + @"\Folder_" + i);

            for (int i = 0; i < 100; i++)
                Directory.Delete(path + @"\Folder_" + i);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string tempPath = path;
            int ir = 100;
            for (int i = 0; i < 100; i++)
            {
                try
                {
                    Directory.CreateDirectory(tempPath + @"\Folder_" + i);
                    tempPath += @"\Folder_" + i;
                }
                catch
                {
                    MessageBox.Show(i.ToString() + " folder: " + tempPath.Substring(tempPath.Length - (7 + i.ToString().Length)));
                    ir = i;
                    break;
                }
            }
            Directory.Delete(path + @"\Folder_0", true);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<string> files = GetFiles(@"E:\IT\WEB HW\JS", textBox1.Text);
            if (files.Count > 0)
            {
                MessageBox.Show("Found!");
                StreamReader reader = new StreamReader(files.First(), Encoding.Default);
                Form2 newf = new Form2(reader);
                reader.Close();
                newf.Show();
            }
            else
                MessageBox.Show("Not found!");
        }

        private List<string> GetFiles(string path, string file)
        {
            var files = new List<string>();

            try
            {
                files.AddRange(Directory.GetFiles(path, file, SearchOption.TopDirectoryOnly));
                foreach (var dir in Directory.GetDirectories(path))
                    files.AddRange(GetFiles(dir, file));
            }
            catch (Exception ex) { }

            return files;
        }
    }
}

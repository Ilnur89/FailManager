using System;
using System.IO;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FailManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            DirectoryInfo dirrectory = new DirectoryInfo(textBox1.Text);
            DirectoryInfo[] dir = dirrectory.GetDirectories();

            foreach (var i in dir)
            {
                listBox1.Items.Add(i);
            }

            FileInfo[] filecor = dirrectory.GetFiles();
            foreach (var j in filecor)
            {
                listBox1.Items.Add(j);
            }
        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (Path.GetExtension(Path.Combine(textBox1.Text, listBox1.SelectedItem.ToString())) == "")
             {
                textBox1.Text = Path.Combine(textBox1.Text, listBox1.SelectedItem.ToString());
                listBox1.Items.Clear();
                DirectoryInfo dirrectory = new DirectoryInfo(textBox1.Text);
                DirectoryInfo[] dir = dirrectory.GetDirectories();

                foreach (var i in dir)
                {
                    listBox1.Items.Add(i);
                }

                FileInfo[] filecor = dirrectory.GetFiles();
                foreach (var j in filecor)
                {
                    listBox1.Items.Add(j);

                }
             }
            else
            {
                Process.Start(Path.Combine(textBox1.Text, listBox1.SelectedItem.ToString()));
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text[textBox1.Text.Length - 1] == '\\')
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
                while (textBox1.Text[textBox1.Text.Length - 1] != '\\')
                {
                    textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
                }
            }
            else if(textBox1.Text[textBox1.Text.Length - 1] != '\\')
            {
                while (textBox1.Text[textBox1.Text.Length - 1] != '\\')
                {
                    textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
                }
            }
            listBox1.Items.Clear();
            DirectoryInfo dirrectory = new DirectoryInfo(textBox1.Text);
            DirectoryInfo[] dir = dirrectory.GetDirectories();

            foreach (var i in dir)
            {
                listBox1.Items.Add(i);
            }

            FileInfo[] filecor = dirrectory.GetFiles();
            foreach (var j in filecor)
            {
                listBox1.Items.Add(j);

            }
        }
    }
}

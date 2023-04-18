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

namespace th2._2
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Lấy đường dẫn và tên file
                string url = openFileDialog.FileName;
                string fileName = openFileDialog.SafeFileName;
                string fileContents = File.ReadAllText(url);
                string t = "Kích thước file: " + new FileInfo(url).Length + " bytes";
                // Đọc nội dung file
                textBox3.Text = url;
                textBox2.Text = t;
                textBox1.Text = fileName;
                


                int numLines = fileContents.Split('\n').Length;
                int numWords = fileContents.Split(new[] { ' ', '\t', '\r', '\n' },
                    StringSplitOptions.RemoveEmptyEntries).Length;
                int numChars = fileContents.Length;
                textBox4.Text = numLines.ToString();
                textBox5.Text = numWords.ToString();
                textBox6.Text = numChars.ToString();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

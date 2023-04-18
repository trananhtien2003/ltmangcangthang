using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace th2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //input1
            using (StreamReader sr = new StreamReader("input1.txt"))
            {
                string contents = sr.ReadToEnd();
                // In nội dung ra màn hình
                Console.WriteLine("Nội dung của tệp tin 'input1.txt':");
                Console.WriteLine(contents);
                // Đưa nội dung vào RichTextBox
                richTextBox1.Text = contents.ToUpper();
            }
                OpenFileDialog name= new OpenFileDialog();

            textBox3.Text = name.SafeFileName.ToString();



        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

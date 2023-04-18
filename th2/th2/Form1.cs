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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (StreamReader sr = new StreamReader("input1.txt"))
            {
                string contents = sr.ReadToEnd();

                // In nội dung ra màn hình
                Console.WriteLine("Nội dung của tệp tin 'input1.txt':");
                Console.WriteLine(contents);

                // Đưa nội dung vào RichTextBox
                richTextBox1.Text = contents.ToUpper();
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Ghi nội dung (chuyển toàn bộ ký tự sang kiểu in hoa) vào tệp tin "output1.txt"
            using (StreamWriter sw = new StreamWriter("output1.txt"))
            {
                sw.Write(richTextBox1.Text);
            }

            MessageBox.Show("Đã ghi nội dung vào tệp tin 'output1.txt");
        }
       
        
    }
}

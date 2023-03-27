using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace th1
{
    public partial class frm5 : Form
    {
        private int b;

        public frm5()
        {
            InitializeComponent();
        }

        private void frm5_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        //tính giai thừa
        //Factorial
        int giaithua(int a)
        {
            int kq = 1;
            for (int i = 1; i <= a; i++)
            {
                kq = kq * i;
            }
            return kq;
        }
        int cong(int a)
        {
            for (int i = 1; i <= a;i++)
            {  b = b +  i; }
            return b ;
        }
        //tính giai thừa
        //Factorial



        private void button1_Click(object sender, EventArgs e)
        {
            //tính A! B!
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            int c = giaithua(a);
            int d = giaithua(b);
            textBox3.Text = c.ToString();
            textBox4.Text = d.ToString();
            //tính tổng từ 1 đến A
            int e1 = cong(a);
            int f = cong(b);
            textBox5.Text = e1.ToString();
            textBox6.Text = f.ToString();






        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

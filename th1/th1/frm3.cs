using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace th1
{
    public partial class frm3 : Form
    {
        public frm3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            string b = a.ToString();
            textBox2.Text = b;
            switch (a)
            {
                case 1:
                    textBox2.Text = "One";
                    break; // Vì case này có lệnh thực hiện nên phải có lệnh break
                    case 2:
                        textBox2.Text = "Two";
                    break; // Vì case này có lệnh thực hiện nên phải có lệnh break
                case 3:
                    textBox2.Text= "Three";
                    break; // Vì case này có lệnh thực hiện nên phải có lệnh break 
                    case 4:
                        textBox2.Text = "Four";
                    break; // Vì case này có lệnh thực hiện nên phải có lệnh break
                    case 5:
                        textBox2.Text = "Five";
                    break; // Vì case này có lệnh thực hiện nên phải có lệnh break
                    case 6:
                        textBox2.Text = "Six";
                    break; // Vì case này có lệnh thực hiện nên phải có lệnh break
                    case 7:
                        textBox2.Text = "Seven";
                    break; // Vì case này có lệnh thực hiện nên phải có lệnh break
                    case 8:
                        textBox2.Text = "Eight";
                    break; // Vì case này có lệnh thực hiện nên phải có lệnh break
                    case 9:
                        textBox2.Text = "Nine";
                    break; // Vì case này có lệnh thực hiện nên phải có lệnh break
                    case 10:
                    default:
                    textBox2.Text = "Nhập lại";
                    break; // Vì case này có lệnh thực hiện nên phải có lệnh break
            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //out put english
            //int a = int.Parse(textBox1.Text);
            //string b = a.ToString();
            //textBox2.Text = b;


        }
    }
}

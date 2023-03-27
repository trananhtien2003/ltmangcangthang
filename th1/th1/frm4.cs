using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace th1
{
    public partial class frm4 : Form
    {
        public frm4()
        {
            InitializeComponent();
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void frm4_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {





        }

        private void button1_Click(object sender, EventArgs e)
        {
            int k = comboBox1.SelectedIndex;
            int a = int.Parse(textBox1.Text);
            switch (k) 
            { 
                case 0 :
                
                a = a * 23;
                textBox2.Text = a.ToString();
                    break;
                    case 1:
                    a=a*25;
                    textBox2.Text = a.ToString();
                    break; 
                    case 2:
                    a=a*29;
                    textBox2.Text = a.ToString();
                    break;


               
            }

            

        }
    }
}

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
    public partial class frm1 : Form
    {
        public frm1()
        {
            InitializeComponent();
        }

        private void frm1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           // check input digit
           //only number  check



           

         

          

            

            if (System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, "[^0-9]")|| System.Text.RegularExpressions.Regex.IsMatch(textBox2.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
                textBox2.Text = textBox2.Text.Remove(textBox2.Text.Length - 1);
  

            }
            else
            {
                int a = int.Parse(textBox1.Text);
                int b = int.Parse(textBox2.Text);
                int c = a + b;
                textBox3.Text = c.ToString();
            }






        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           


           
        }
        //check number 2 text box
       
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace WindowsFormsApp1
{
    public partial class Bai1 : Form
    {
        public Bai1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Thread thd2 = new Thread(new ThreadStart(MethodB));
            thd2.Start();
        }

        private void Bai1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread thd1 = new Thread(new ThreadStart(MethodA));
            thd1.Start();
        }
        public void MethodA()
        {
            new UDPServer().ShowDialog();
        }

        public void MethodB()
        {
            new UDPClient().ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}

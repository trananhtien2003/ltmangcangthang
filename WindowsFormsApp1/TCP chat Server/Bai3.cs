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
    public partial class Bai3 : Form
    {
        public Bai3()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }
        void MethodA()
        {
            new TCPserver().ShowDialog();
        }
        void MethodB()
        {
            new TCPclient().ShowDialog();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Thread t1 = new Thread(new ThreadStart(MethodA));
            t1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Thread t2 = new Thread(new ThreadStart(MethodB));
            t2.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

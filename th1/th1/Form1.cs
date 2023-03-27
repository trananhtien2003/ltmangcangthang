namespace th1
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
            frm1 frm = new frm1();
            frm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frm2 frm = new frm2();
            frm.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm3 frm = new frm3();
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frm5 frm = new frm5();
            frm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frm6 frm = new frm6();
            frm.Show();

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            frm4 frm = new frm4();
            frm.Show();
        }
    }
}
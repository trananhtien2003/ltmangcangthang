using System;
using System.Collections;
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
    
    public partial class Form2 : Form
    {
        static int finalResult;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {
            string inputFileName = "input3.txt";
            StreamReader reader = new StreamReader(inputFileName);
            string contents = reader.ReadToEnd();






            // Đọc từng dòng trong file
            while (!reader.EndOfStream)
            {
                string  line = reader.ReadLine();
                string[] lines = File.ReadAllLines("input3.txt");
                    

                // Tách các phép toán và toán hạng
                string[] tokens = line.Split(' ');

                // Sử dụng stack để tính toán theo thứ tự ưu tiên
                Stack<int> stack = new Stack<int>();

                // Duyệt các phép toán và toán hạng từ trái qua phải
                foreach (string token in tokens)
                {
                    int operand;

                    // Nếu token là số, đưa vào stack
                    if (int.TryParse(token, out operand))
                    {
                        stack.Push(operand);
                    }
                    else
                    {
                        // Nếu token là toán tử, lấy ra 2 toán hạng ở đỉnh của stack
                        int operand2 = stack.Pop();
                        int operand1 = stack.Pop();
                        int result;

                        // Thực hiện phép toán
                        switch (token)
                        {
                            case "+":
                                result = operand1 + operand2;
                                break;
                            case "-":
                                result = operand1 - operand2;
                                break;
                            case "*":
                                result = operand1 * operand2;
                                break;
                            case "/":
                                result = operand1 / operand2;
                                break;
                            default:
                                throw new ArgumentException("Invalid operator: " + token);
                        }

                        // Đưa kết quả vào stack
                        stack.Push(result);
                    }
                }


                // Kết quả cuối cùng nằm ở đỉnh của stack
                int finalResult = stack.Pop();
            }
                richTextBox1.Text =finalResult.ToString();

                // Ghi kết quả vào file output3.txt
               
            
        }

        public void button2_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter("output3.txt"))
            {

                sw.Write(richTextBox1.Text);
            }
            MessageBox.Show("Đã ghi nội dung vào tệp tin 'output3.txt");
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

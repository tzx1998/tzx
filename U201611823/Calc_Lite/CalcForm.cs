using System;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class CalcForm : System.Windows.Forms.Form
    {
        public CalcForm()
        {
            InitializeComponent();
        }

        private double num_1 = 0; // 第一计算数
        private double num_2 = 0; // 第二计算数
        private double num_result = 0; // 结果
        private string sign; // 运算符号
        private bool flag = true; // 检查是否为第一操作数

        public void InputData(Object obj) {
            Button b = (Button)obj;
            InputData(b.Text);
        }
        public void InputData(String obj)
        {
            result.Text += obj;
            if (flag)
            {
                num_1 = Convert.ToDouble(result.Text);
                if (num_1 < 0)
                {
                    MessageBox.Show("Only 0-10000 of the data can be calculated");
                    num_1 = 0;
                    result.Text = "";
                }
            }
            else
            {
                num_2 = Convert.ToDouble(result.Text);
                if (num_2 < 0)
                {
                    MessageBox.Show("Only 0-10000 of the data can be calculated");
                    num_2 = 0;
                    result.Text = "";
                }
            }
            calc.Focus();
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (true) return; //注销掉键盘输入
        }

        /// <summary>
        /// 计算
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void calc_Click(object sender, EventArgs e)
        {
            flag = true;
            switch (sign)
            {
                case "+":
                    num_result = num_1 + num_2;
                    break;
                case "-":
                    num_result = num_1 - num_2;
                    break;
                case "*":
                    num_result = num_1 * num_2;
                    break;
                case "/":
                    {
                        result.Text = "";
                        if (num_2 == 0)
                        {
                            result.Clear();
                            MessageBox.Show("除数不能为0，请重新输入除数");
                            num_2 = 0;
                            flag = false;
                            result.Clear();
                            return;
                        }
                        else
                        {
                            num_result = num_1 / num_2;
                            break;
                        }
                    }
            }
            result.Text = num_result.ToString();
            num1 = num3;

        }


        private void num_click(object sender, EventArgs e) {
            InputData(sender);
        }

        
        /// <summary>
        /// 小数点
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button19_Click(object sender, EventArgs e)
        {
            if (result.Text == "")
            {
                result.Text = "0.";
            }
            else if (result.Text.IndexOf(".") >= 0)
            {
                MessageBox.Show("已经添加小数点l！", "提示");
            }
            else
            {
                result.Text += ".";
            }
        }

        /// <summary>
        /// 0
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button18_Click(object sender, EventArgs e)
        {
            if (result.Text != "")
            {
                InputData(sender);
            }
        }

        private void division_Click(object sender, EventArgs e)
        {
            sign = "/";
            result.Text = "";
            flag = false;
            calc.Focus();
        }

        private void multiplication_Click(object sender, EventArgs e)
        {
            sign = "*";
            result.Text = "";
            flag = false;
            calc.Focus();
        }

        private void subtraction_Click(object sender, EventArgs e)
        {
            sign = "-";
            result.Text = "";
            flag = false;
            calc.Focus();
        }

        private void add_Click(object sender, EventArgs e)
        {
            sign = "+";
            result.Text = "";
            flag = false;
            calc.Focus();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            result.Text = "";
            num_1 = 0;
            num_2 = 0;
            num_result = 0;
            flag = true;
            calc.Focus();
        }

        private void buttonexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CalcForm_Load(object sender, EventArgs e)
        {
            calc.Focus();
        }

        private void result_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

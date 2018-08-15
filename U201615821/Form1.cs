using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        double a = 0;//输出结果
        double b = 0;//输入的第一个数
        bool c = false;//true为运算，false为输入数
        string d;//显示框内文字
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //button1到0是输入数字
        private void button1_Click(object sender, EventArgs e)
        {
            if (c == true)
            {
                textBox1.Text = "";
                c = false;
            }
            textBox1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (c == true)
            {
                textBox1.Text = "";
                c = false;
            }
            textBox1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (c == true)
            {
                textBox1.Text = "";
                c = false;
            }
            textBox1.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (c == true)
            {
                textBox1.Text = "";
                c = false;
            }
            textBox1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (c == true)
            {
                textBox1.Text = "";
                c = false;
            }
            textBox1.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (c == true)
            {
                textBox1.Text = "";
                c = false;
            }
            textBox1.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (c == true)
            {
                textBox1.Text = "";
                c = false;
            }
            textBox1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (c == true)
            {
                textBox1.Text = "";
                c = false;
            }
            textBox1.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (c == true)
            {
                textBox1.Text = "";
                c = false;
            }
            textBox1.Text += "9";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (c == true)
            {
                textBox1.Text = "";
                c = false;
            }
            textBox1.Text += "0";
            if (d == "/")
            {
                textBox1.Clear();
                MessageBox.Show("除数不能为零", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            c = true;
            b = double.Parse(textBox1.Text);
            d = "+";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            c = true;
            b = double.Parse(textBox1.Text);
            d = "-";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            c = true;
            b = double.Parse(textBox1.Text);
            d = "*";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            c = true;
            b = double.Parse(textBox1.Text);
            d = "/";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            switch (d)
            {
                case "+": a = b + double.Parse(textBox1.Text); break;
                case "-": a = b - double.Parse(textBox1.Text); break;
                case "*": a = b * double.Parse(textBox1.Text); break;
                case "/": a = b / double.Parse(textBox1.Text); break;
            }
            textBox1.Text = a + "";
            c = true;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
    }
}

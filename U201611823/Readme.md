# 关于简单计算器程序的介绍

## 一、程序简介

1. 实现数字间简单计算。
2. 实现清空、退出键功能。 

## 二、部分代码

1. 计算器初始化

```c#
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

        private double num_1 = 0;
        private double num_2 = 0;
        private double num_result = 0;
        private string sign;
        private bool flag = true;
```

2. 部分按钮功能实现

```c#
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
```

## 三、成品展示

![5O4)I3T~QY9A%20@2BZE3{1](C:\Users\lenovo\Desktop\5O4)I3T~QY9A%20@2BZE3{1.png) 

## 四、程序缺陷

1. 界面单调平淡。
2. 计算功能较少。




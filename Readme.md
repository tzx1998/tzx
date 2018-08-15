我们小组成员在暑假中学习了不同的语言，编写了几个简单的小demo，虽然不复杂，但都能够运用学习到的内容，锻炼了编程能力。在编程中也意识到自己的一些不足，发现了一些错误，我们会尝试在以后编程过程中加以改正，不断学习。
-- -
    1. 汤智鑫 
# <font color=#FFFF00><center>***预习demo介绍***</center>

## **实现功能**
该程序是一个小计算器，可以实现十进制数字的加减乘除运算。清零键可以清除键盘上显示的数字，重新输入。主要的步骤有两点，一是**输入数字**，二是**进行四则运算**，并且在显示屏上**显示数字与答案**。其中输入数字时需要进行判断*是否处于运算状态*，即*前一步是否点击运算符*。
## **代码重现**

```C
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
            if (c == true)//判断是否处于待运算状态，如果是则令其为否，表示已经进行运算
            {
                textBox1.Text = "";
                c = false;
            }
            textBox1.Text += "1";//屏幕上显示点击的数值
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
        {2
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
        //输入四个运算符
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
        //进行运算
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
        //AC键清零
        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
    }
}
```
## **运行界面**
![计算器](jisuanqi.jpg "计算器界面")
## **优点缺点**
- 该程序比较简单，代码清晰明白，容易上手，便于C#的入门
- 操作界面直白，方便使用者使用
- 实现用途不多，无法发布
## **改进计划**
- 添加小数点按键，能够完成小数的运算
- 添加十进制二进制转换案件，用户可以选择二/十进制来计算
- 添加历史记录，用户可以查询计算历史
- 添加Ans案件调用前次计算结果
- 添加退格键，消去错误输入
</font>
---
    2. 李浩民

 # <font face="华文楷体" color=#00FFFF size=8> <center> **贪吃蛇代码** </center> </font>
 ## **<font color=#00FFFF>一、 简述思路**  </font>
 1.利用二维数组0/1构建地图边界    
 2.利用二维数组构建蛇身体并实现移动  
 3.利用随即种子构建食物  
 4.判断是否吃到食物  
 5.利用kbhit函数检测是否按键  
 6.检测游戏结束条件   
  
 ##  **<font color=#00FFFF> 二、部分代码构建** </font>  
  ### 1.所需调用库及初始化   
 ~~~ C++  
# include <stdio.h>
# include <string.h>//字符数组调用
# include <windows.h>
# include <stdlib.h>
# include <conio.h>  //控制台输入输出程序
# include <time.h>//随即种子

const  int length = 5;
const int line = 30;
const int row = 20;

//初始化
int head_x = row / 2, head_y = line / 2;
int head_v = 5;
int Tail_x = 0, Tail_y = 0;
int count = 0;
char direct = 'a';
void creatmap(char map[row][line]);//用来创建地图
void creatsnake(int snake[row][line]);
void  showmap(char map[row][line], int snake[row][line]);
void run(char map[row][line], int snake[row][line]);
int judge(void);
void creatfood(char map[row][line], int snake[row][line]);
void movetail(int snake[row][line]);
int eatfood(char  map[row][line], int snake[row][line]);  
~~~  
### 2.重要函数样例
（1）. 蛇身构建  
~~~ C++ 
void creatsnake(int snake[row][line])
{
	int i, j;
	int 	value = head_v=5;
	snake[head_x][head_y] = value;
	for (i = head_x, j = head_y+1; j < head_y + length;	++j)
	{
		snake[i][j] = --value;	
	
	
	}
	Tail_x = i;
	Tail_y = j-1;
}
~~~  
注释：同样是二维数组，给蛇头加上编号直到蛇尾为1，在最后现实中，对二维数组进行检验，如果存储得数为不为0，则输出字母（蛇身）。    
（2）.检验键盘是否敲下
~~~C++  
	if (kbhit()) {

		ch = getch();
		if (ch == -32) {

			sh = getch();
			switch (sh) {

			case 'H': direct = 'w'; break;
			case 'P': direct = 's'; break;
			case 'K': direct = 'a'; break;
			case 'M': direct = 'd'; break;
					}
				}
		else {
			switch (ch) {

			case 'w':case 'W': direct = 'w'; break;
			case 's':case 'S': direct = 's'; break;
			case 'a':case 'A': direct = 'a'; break;
			case 'd':case 'D': direct = 'd'; break;

					}
				}
			}
~~~  
注释：利用kbhit函数，分四种情况进行检验，之后再根据这四种情况进行蛇的移动。   
 ##  **<font color=#00FFFF> 三、最终样品** </font>    
 ![Alt 最终结果](pi.png)  
 ##  **<font color=#00FFFF> 四、存在缺陷** </font>    
1.游戏界面枯燥没有新意  
2.游戏功能比较单一，下一步可以试着控制速度与显示结果  
3.尝试双人模式的贪吃蛇

---
    3. 杨王旺
# 贪吃蛇HTML5

## 一、初始化
	
定义格子的大小，蛇头以及食物。

```html
var canvas = document.getElementById("myCanvas");
var ctx = canvas.getContext("2d");
var w = 15; //格子宽、高
var snaLen = 6; //初始长度
var snake = []; //身体长度
for (var i = 0; i < snaLen; i++) {
    snake[i] = new cell(i, 0, 39);
}
var head = snake[snaLen - 1]; //头部
//初始食物
var foodx = Math.ceil(Math.random() * 28 + 1);
var foody = Math.ceil(Math.random() * 28 + 1);
var food = new Food(foodx, foody);
//食物
function Food(x, y) {
    this.x = x;
    this.y = y;
    return this;
}

//身体
function cell(x, y, d) {
    this.x = x;
    this.y = y;
    this.d = d;
    return this;
}

```

## 二、绘制

```html
//画布局
    //      for(var i = 0; i < 30; i++){
    //          ctx.strokeStyle = "#ccc";//线条颜色
    //          ctx.beginPath();
    //          ctx.moveTo(0,i*w);
    //          ctx.lineTo(450,i*w);

    //          ctx.moveTo(i*w,0);
    //          ctx.lineTo(i*w,450);
    //          ctx.closePath();
    //          ctx.stroke();
    //      }
    //画蛇身
    for (var j = 0; j < snake.length; j++) {
        ctx.fillStyle = "green";
        if (j == snake.length - 1) {
            ctx.fillStyle = "red";
        }
        ctx.beginPath();
        ctx.rect(snake[j].x * w, snake[j].y * w, w, w);
        ctx.closePath();
        ctx.fill();
        ctx.stroke();
    }
```

## 三、食物以及吃到食物

```html
//吃到食物
    if (head.x == food.x && head.y == food.y) {
        initFood();
        food = new Food(foodx, foody);
        //重新出现食物
        drawFood();

        //增加蛇的长度  有些小瑕疵，蛇身增长时应该是身体增长，而不是在蛇头上增长
        var newCell = new cell(head.x, head.y, head.d);
        switch (head.d) {
            case 40:
                newCell.y++;
                break; //下
            case 39:
                newCell.x++;
                break; //右
            case 38:
                newCell.y--;
                break; //上
            case 37:
                newCell.x--;
                break; //左
        }
        snake[snake.length] = newCell;
        head = newCell;
        //head = 
    }
}
//随机初始化食物
function initFood() {
    foodx = Math.ceil(Math.random() * 28 + 1);
    foody = Math.ceil(Math.random() * 28 + 1);
    for (var i = 0; i < snake.length; i++) {
        if (snake[i].x == foodx && snake[i].y == foody) {
            initFood();
        }
    }
}
```

## 四、运动

蛇的前进方向来自玩家的键盘输入，需要对键盘输入进行检测：

```html

```

控制蛇移动方向：

```html

```

## 五、规则

```html
function checkDeath() {
    //超出边框
    if (head.x >= 30 || head.y >= 30 || head.x < 0 || head.y < 0) {
        alert("Game over!");
        window.location.reload();
    }
    //咬到自己
    for (var i = 0; i < snake.length - 1; i++) {
        if (head.x == snake[i].x && head.y == snake[i].y) {
            alert("Game over!");
            window.location.reload();
        }
    }
}
//蛇自动走
function moveClock() {
    moveSnake(head.d);
}
var isMove = false;
function beginGame() {
    !isMove && setInterval(moveClock, 300);
    isMove = true;
}

```
  ---  
    4. 许俊
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
---                
    5. 杨雨
# 关于五子棋程序的介绍

## 一、简述思路

1. 利用二维数组记录棋盘状态
2. 为所有picturebox添加单击事件
3. 获取所点击格子所在的位置，如果该位置已经有棋子则不能落子
4. 判断白棋或黑棋是否五子连珠，共有五种情况，记录白棋或者黑棋赢的局数

## 二、部分代码构建

### 1.棋盘初始化

```c#
 private void 开始RToolStripMenuItem_Click(object sender, EventArgs e)
        {
            state = new int[15, 15];//初始化
            b = true;
            foreach (object item in this.Controls)
            {
                PictureBox pic=item as PictureBox;
                if(pic!=null)
                {
                    pic.BackgroundImage=null;//背景图片初始化
                }
            }
            MessageBox.Show("重开成功,白子先行!");
        }
```

### 2.成功条件判定（部分）

```c#
        private Boolean IsWhiteResult(int row, int col,int type)
        {
            //一共有5种可能
            int count = 1;
            for (int i = 1; i < 5; i++)
            {
                if (col + 1 < 15 && state[row, col + i] == type)//右边横轴
                {
                    count++;
                }
                else
                    break;
            }
            for (int i = 1; i < 5; i++)
            {
                if (col - i >= 0 && state[row, col - i] == type)//左边横轴
                {
                    count++;
                }
                else
                    break;
            }
            if (count >= 5)//如果左右满足胜利要求 则无需计算上下 以及斜面的棋子个数
                return true;
```

## 三、最终样品

![QQ图片20180813195228](C:\Users\user\Desktop\QQ图片20180813195228.jpg)



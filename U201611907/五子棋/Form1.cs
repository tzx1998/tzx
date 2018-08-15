using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 五子棋
{
    public partial class HomeFrm : Form
    {
        public HomeFrm()
        {
            InitializeComponent();
        }
        static Boolean b = true;//记录白黑子
        static int[,] state = new int[15, 15];//15*15 记录棋盘的状态
        static int whiteCount = 0;//记录白子赢的局数
        static int BlackCount = 0;//记录黑子赢的局数
        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (object item in this.Controls)
            {
                PictureBox pic = item as PictureBox;
                if (pic != null)
                {
                    pic.Click += pic_Click;//为所有picturebox添加单击事件
                }
            }
        }

        void pic_Click(object sender, EventArgs e)
        {
            PictureBox pic = sender as PictureBox;
            int row = int.Parse(pic.Name.Substring(4, pic.Name.Length - 4)) / 15;//获取点击格子的所在行
            int col = (int.Parse(pic.Name.Substring(4, pic.Name.Length - 4)) - 1) % 15;//获取点击格子的所在列
            if (pic.BackgroundImage != null)//如果该位置上已经有子了 则不能下子
            {
                return;
            }

            if (b)
            {
                Bitmap bm = new Bitmap(@"../../Resources/white.png");
                pic.BackgroundImage = bm;
                pic.Tag = "W";//白子则标记为W 即White的缩写
                lbl_BlackState.Text = "状态：正在出棋";
                lbl_WhiteState.Text = "状态：等待中";
                state[row, col] = 1;//为白子标记
                if (IsWhiteResult(row, col,1))//判断白子结果是否5子连珠
                {
                    MessageBox.Show("白方胜");
                    whiteCount++;//胜利局数+1
                    lbl_WhiteWin.Text ="胜局："+whiteCount;
                }
            }
            else
            {
                Bitmap bm = new Bitmap(@"../../Resources/Black.png");
                pic.BackgroundImage = bm;
                pic.Tag = "B";//黑子则标记为B 即Black缩写
                lbl_BlackState.Text = "状态：等待中";
                lbl_WhiteState.Text = "状态：正在出棋";
                state[row, col] = 2;//为黑子标记
                if (IsWhiteResult(row, col, 2))//判断黑子结果是否5子连珠
                {
                    MessageBox.Show("黑方胜");
                    BlackCount++;//胜利局数+1
                    lbl_BlackWin.Text = "胜局：" + BlackCount;
                }
            }
            b = !b;
        }

        /// <summary>
        /// 判断是否胜利的方法
        /// </summary>
        /// <param name="row"></param>
        /// <param name="col"></param>
        /// <param name="type"></param>
        /// <returns></returns>
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
            else//左右不满足 计算上下
            {
                int count2 = 1;
                for (int i = 1; i < 5; i++)
                {
                    if (row - i >= 0 && state[row - i, col] == type)
                    {
                        count2++;
                    }
                    else break;
                }
                for (int i = 1; i < 5; i++)
                {
                    if (row + i < 15 && state[row + i, col] == type)
                    {
                        count2++;
                    }
                    else break;
                }
                if (count2 >= 5)
                    return true;
                else//表示上下也并没有满足要求 则计算斜边
                {
                    int count3 = 1;
                    for (int i = 1; i < 5; i++)//右上
                    {
                        if (col + i < 15 && row - i >= 0 && state[row - i, col + i] == type)
                        {
                            count3++;
                        }
                        else 
                            break;
                    }
                    for (int i = 1; i < 5; i++)//左下
                    {
                        if (row + i < 15 && col - i >= 0 && state[row + i, col - i] == type)
                        {
                            count3++;
                        }
                        else 
                            break;
                    }
                    if (count3 >= 5)
                        return true;
                    else//右上左下不满足要求
                    {
                        int count4 = 1;
                        for (int i = 1; i < 5; i++)//右上
                        {
                            if (col - i >= 0 && row - i >= 0 && state[row - i, col - i] == type)
                            {
                                count4++;
                            }
                            else
                                break;
                        }
                        for (int i = 1; i < 5; i++)//左下
                        {
                            if (row + i < 15 && col + i < 15 && state[row + i, col + i] == type)
                            {
                                count4++;
                            }
                            else
                                break;
                        }
                        if (count4 >= 5) 
                            return true;
                    }
                }
            }
            return false;//全都不满足要求
        }

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
    }
}

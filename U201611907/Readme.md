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
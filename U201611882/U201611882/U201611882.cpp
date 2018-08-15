// U201611882.cpp: 定义控制台应用程序的入口点。
//

#include "stdafx.h"
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


//开始构造函数
void creatmap(char map[row][line])
{
	int i, j;
	for (i = 0; i < row; ++i)
		map[i][0] = '#';
	for (j = 1; j < line; ++j)
		map[0][j] = '#';
	for (i = row - 1, j = 1; j < line; ++j)
		map[i][j] = '#';
	for (j = line - 1, i = 1; i < row; ++i)
		map[i][j] = '#';
}

void creatsnake(int snake[row][line])
{
	int i, j;
	int 	value = head_v = 5;
	snake[head_x][head_y] = value;
	for (i = head_x, j = head_y + 1; j < head_y + head_v; ++j)
	{
		snake[i][j] = --value;


	}
	Tail_x = i;
	Tail_y = j - 1;
}



void creatfood(char map[row][line], int snake[row][line])
{
	int food_x = 0, food_y = 0;
	while (snake[food_x][food_y] != 0 || map[food_x][food_y] == '#')
	{
		food_x = rand() % (row - 3) + 1;
		food_y = rand() % (line - 3) + 1;
	}
	map[food_x][food_y] = 'O';



}

void  showmap(char map[row][line], int snake[row][line])
{
	int i, j;
	for (i = 0; i < row; ++i)
	{
		for (j = 0; j < line; ++j)
		{
			if (snake[i][j] == 0)
				printf("%c", map[i][j]);
			else {
				if (snake[i][j] == head_v)
				{
					printf("%c", 'H');
				}
				else printf("%c", 'h');
			}

		}putchar('\n');

	}

}

int judge(void)
{
	if ((head_x == 0 || head_x == row - 1) || (head_y == 0 || head_y == line - 1))
		return 0;
	else
		return 1;


}

void movetail(int snake[row][line])
{
	if (snake[Tail_x][Tail_y] + 1 == snake[Tail_x - 1][Tail_y]) {

		snake[Tail_x][Tail_y] = 0;
		Tail_x--;
	}
	else if (snake[Tail_x][Tail_y] + 1 == snake[Tail_x + 1][Tail_y]) {

		snake[Tail_x][Tail_y] = 0;
		Tail_x++;
	}
	else if (snake[Tail_x][Tail_y] + 1 == snake[Tail_x][Tail_y - 1]) {

		snake[Tail_x][Tail_y] = 0;
		Tail_y--;
	}
	else {

		snake[Tail_x][Tail_y] = 0;
		Tail_y++;
	}

}
int eatfood(char  map[row][line])
{
	if (map[head_x][head_y] == 'O')
	{
		map[head_x][head_y] = 0;
		count++;
		return 0;
	}
	else
		return 1;
}

void run(char map[row][line], int snake[row][line])
{
	char sh, ch;
	while (1) {

		if (judge()) {
			/**********判断键盘是否敲击***********/
			if (_kbhit()) {

				ch = _getch();
				if (ch == -32) {

					sh = _getch();
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
			/************************************/

			/**************蛇的运动******************/
			switch (direct) {

			case 'w':
				if (snake[head_x - 1][head_y] != 0)
					return;

				snake[head_x - 1][head_y] = ++head_v;
				head_x--;
				if (eatfood(map))
					movetail(snake);
				else
					creatfood(map, snake);
				break;
			case 'a':
				if (snake[head_x][head_y - 1] != 0)
					return;

				snake[head_x][head_y - 1] = ++head_v;
				head_y--;
				if (eatfood(map))
					movetail(snake);
				else
					creatfood(map, snake);
				break;
			case 's':
				if (snake[head_x + 1][head_y] != 0)
					return;

				snake[head_x + 1][head_y] = ++head_v;
				head_x++;
				if (eatfood(map))
					movetail(snake);
				else
					creatfood(map, snake);
				break;
			case 'd':
				if (snake[head_x][head_y + 1] != 0)
					return;

				snake[head_x][head_y + 1] = ++head_v;
				head_y++;
				if (eatfood(map))
					movetail(snake);
				else
					creatfood(map, snake);
				break;
			}
			system("cls");
			showmap(map, snake);
			/****************************************/
		}
		else
			return;
	}
}


int main()
{
	char map[row][line];
	int snake[row][line];
	srand(time(NULL));
	memset(map, 0, sizeof(map));
	memset(snake, 0, sizeof(snake));
	system("cls");
	creatmap(map);
	creatsnake(snake);
	creatfood(map, snake);
	showmap(map, snake);
	run(map, snake);


	return 0;
}


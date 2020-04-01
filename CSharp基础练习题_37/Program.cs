/*
 * 时    间：2020年2月29日20:34:55
 * 题    目：37.编一个程序，定义一个有10个元素的数组，使用for循环语句，
 *              从键盘上输入10名同学的数学成绩，分别求出最高分和最低分，并且求出10名同学的数学平均成绩。
 * 知 识 点：
 * 操作步骤：
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp基础练习题_37
{
    class Program
    {
        static void Main(string[] args) {
            int[] score = new int[10] { 20, 60, 41, 52, 90, 82, 70, 30, 100, 88 };
            int i = 0;
            int max = score[0];
            int min = score[0];
            int sum = 0;
            int avg = 0;
            //求最高分数
            while (i < score.Length)
            {
                if (max < score[i])
                {
                    max = score[i];
                }
                //求最低分数
                if (min > score[i])
                {
                    min = score[i];
                }

                sum += score[i];
                avg = sum / score.Length;
                i++;
            }
            Console.WriteLine("最高分数：{0}\n最低分数：{1}\n平均分数：{2}", max, min,avg);

            Console.ReadKey();
        }
    }
}

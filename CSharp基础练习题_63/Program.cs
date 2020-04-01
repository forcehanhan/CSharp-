/*
 * 时    间：2020年3月5日20:04:57
 * 题    目：63.编一个程序，定义一个n行n列的二维数组，例如，n=4,输入该数组的全部数据。
 *          可以在定义数组时赋于常量值。求二维数组中这样元素的位置:它在行上是最小，在列上也是最小。
 *          (注意: 它未必是整个数组的最小元素。)
 * 知 识 点：
 * 操作步骤：
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp基础练习题_63
{
    class Program
    {
        static void Main(string[] args) {
            int n = 4;//n行
            int[,] a = {
                { 25, 12, 22, 14 },
                { 15, 16, 17, 18 },
                { 19, 20, 21, 13 },
                { 23, 24, 11, 26 }
            };
            int i, j, k, temp, min;
            //打印出n*n的行列式
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write("{0}  ", a[i, j]);
                }
                Console.WriteLine();
            }

            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    min = a[i, j];
                    //min = temp;//遍历每一个元素，使其等于min

                    //1、寻找第i行的最小元素
                    for (k = 0; k < n; k++)
                    {
                        if (min > a[i, k])
                        {
                            min = a[i, k];
                        }
                    }

                    //2、寻找第k列的最小元素
                    for (k = 0; k < n; k++)
                    {
                        if (min > a[k, j])
                        {
                            min = a[k, j];
                        }
                    }

                    //3、输出

                    if (min == a[i, j])
                    {
                        Console.Write("第{0}行，第{1}列，最小数：{2}  ", i, j, min);
                    }

                }//for:第2层

                Console.WriteLine();
            }//for:第1层
            Console.ReadKey();
        }
    }
}
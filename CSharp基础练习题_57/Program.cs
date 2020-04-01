/*
 * 时    间：2020年3月2日11:08:34
 * 题    目：57.编一个程序，定义一个n行n列的二维整数数组，赋初值，然后求出对角线上的元素之和。
 * 知 识 点：
 * 操作步骤：
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp基础练习题_57
{
    class Program
    {
        static void Main(string[] args) {
            int[,] arr = new int[3, 3] {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }};
            int sum = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j <3; j++)
                {
                    Console.Write("{0}  ", arr[i, j]);
                }
                Console.WriteLine();
            }


            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j <3; j++)
                {
                    if (i == j || j==2 - i)
                    {
                        sum += arr[i, j];
                    }
                }
            }
            Console.Write("对角线线上的和 = {0}  ", sum);
            Console.ReadKey();
        }
    }
}
//1  2  3
//4  5  6
//7  8  9
//对角线线上的和 = 25
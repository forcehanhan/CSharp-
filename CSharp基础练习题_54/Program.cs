/*
 * 时    间：2020年3月1日23:01:55
 * 题    目：54.编一个程序，利用for语句，打印一个如下形式的一个直角三角形，顶点在屏幕中线上，行数从键盘输入。
            *
            **
            ***
            ****
 * 知 识 点：
 * 操作步骤：
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp基础练习题_54
{
    class Program
    {
        static void Main(string[] args) {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("×");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
//×
//××
//×××
//××××
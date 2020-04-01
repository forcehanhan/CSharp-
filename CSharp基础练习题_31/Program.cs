/*
 * 时    间：2020年2月29日11:48:21
 * 题    目：31.Fibonacci序列的前二项是0和1，且每一个后继项是前二项的和。编一个程序，输出项值不大于100的Fibonacci序列。
 * 知 识 点：
 * 操作步骤：
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp基础练习题_31
{
    class Program
    {
        static void Main(string[] args) {

            //                   序号:0, 1, 2, 3, 4, 5, 6, 7, 8, 9,10,...   
            //斐波那契数列（Fibonacci）:1, 1, 2, 3, 5, 8,13,21,34,55,89,...

            int f1 = 0;
            int f2 = 1;
            int f3;
            while (f1 <= 100)
            {
                f3 = f2 + f1;
                Console.WriteLine("{0 }", f1);
                f1 = f2;
                f2 = f3;
            }

            Console.ReadKey();
        }
    }
}
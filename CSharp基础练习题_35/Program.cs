/*
 * 时    间：2020年2月29日18:41:42
 * 题    目：35.编一个程序，用for循环语句求出1到100之间的奇数之和。
 * 知 识 点：
 * 操作步骤：
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp基础练习题_35
{
    class Program
    {
        static void Main(string[] args) {
            int number = 1;
            int sum = 0;
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 != 0)
                {
                    sum += i; 
                }
            }
            Console.WriteLine("1到100之间的奇数之和 = "+sum);//2500
            Console.ReadKey();
        }
    }
}

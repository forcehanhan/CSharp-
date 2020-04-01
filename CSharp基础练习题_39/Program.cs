/*
 * 时    间：2020年2月29日21:25:12
 * 题    目：39.编一个程序，用for循环语句求出1到100之间的奇数之和,以及偶数之和。
 * 知 识 点：
 * 操作步骤：
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp基础练习题_39
{
    class Program
    {
        static void Main(string[] args) {
            int s1 = 0;
            int s2 = 0;
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 != 0)
                {
                    s1 += i;
                }
                if (i % 2 == 0)
                {
                    s2 += i;
                }
            }
            Console.WriteLine("奇数之和={0}，偶数之和={1}", s1, s2);
            Console.ReadKey();
        }
    }
}
//奇数之和=2500，偶数之和=2550
/*
 * 时    间：2020年2月27日23:05:38
 * 题    目：22.编一个程序，从键盘上输入二个实数，使用Math类中Max(和Mn()方法，求出它们中的最大数和最小数。
 * 实现目的：
 * 操作步骤：
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp基础练习题_22
{
    class Program
    {
        static void Main(string[] args) {
            double d1 = 3.121f;
            double d2 = 12133.12121f;
            double Max = Math.Max(d1, d2);
            double Min = Math.Min(d1, d2);
            Console.WriteLine("Max={0},Min={1}. ",Max,Min);
            Console.ReadKey();
        }
    }
}

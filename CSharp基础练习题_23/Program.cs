/*
 * 时    间：2020年2月27日23:51:51
 * 题    目：23.编一个程序，利用whle循环语句和Math类中的Pow()方法，求出1到10的各个数的平方之和。
 * 实现目的：
 * 操作步骤：
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp基础练习题_23
{
    class Program
    {
        static void Main(string[] args) {
            double sum = 0.0f;
            for (int i = 1; i <= 10; i++)
            {
                sum += Math.Pow(i, 2);
            }
            Console.WriteLine("Sum = " + sum);
            Console.ReadKey();
        }
    }
}
/*Sum = 385*/

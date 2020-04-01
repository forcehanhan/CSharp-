/*
 * 时    间：2020年2月29日12:12:54
 * 题    目：32.编一个程序，输入a、b、c的值，求出一元二次方程a*x*x + b*x + c = 0的二个实数根。
 *          计算二个实数根必须使用Math类中的sqrt()方法，计算指定数的开方。
 *          计算二个实数根，可以用公式(b+ Math.Sqrt(b*b-4*a*c)/(2*a)和(-b-Math.Sqrt(b*b-4*a*c)/(2*a)。
 * 知 识 点：
 * 操作步骤：
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp基础练习题_32
{
    class Program
    {
        static void Main(string[] args) {
            int a = 2;
            int b = 3;
            int c = 1;
            double x1;
            double x2;
            x1 = b + Math.Sqrt((b * b - 4 * a * c) / (2 * a));
            x2 = -b - Math.Sqrt((b * b - 4 * a * c) / (2 * a));

            Console.WriteLine("x1={0},x2={1}",x1,x2);
            Console.ReadKey();
        }
    }
}

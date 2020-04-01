/*
 * 时    间：2020年3月6日22:56:01
 * 题    目：73.编一个程序，输入a，b，c的值，定义一个静态方法，求出一元二次方程a*x*x+b*x+c=0的二个实数根。
 * 计算二个实数根必须使用Math类中的Sqrt()方法，计算指定数的开方。
 * 计算二个实数根，可以用公式(-b+Math.Sqrt(b*b-4*a*c)/(2*a)和(-b-Math.Sqrt(b*b-4*a*c))/(2*a)。
 * 例题：
 *  1.方程x(x-2)=3x的解为(B)
         A. x=5     B.X1=0，X2=5     C.X1=2，X2=0     D. X1=0，X2= - 5
 * 知 识 点：
 * 操作步骤：
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp基础练习题_73
{
    class MyClass
    {
        public static void GetGolution(double a, double b, double c) {
            double x1, x2;
            if (b * b - 4 * a * c > 0)
            {
                Console.WriteLine("有两个解：");
                x1 = (-b + Math.Sqrt(b * b - 4 * a * c)) / (2 * a);
                x2= (-b - Math.Sqrt(b * b - 4 * a * c) )/ (2 * a);
                Console.WriteLine("x1 = {0}, x2 = {1}",x1,x2);
            }
            else if (b * b - 4 * a * c == 0)
            {
                Console.WriteLine("有一个解：");
                x1 = -b + Math.Sqrt(b * b - 4 * a * c) / (2 * a);
                x2 = x1;
                Console.WriteLine("x1 = x2 = {0}", x1);
            }
            else
            {
                Console.WriteLine("无解！");
            }
        }
    }
    class Program
    {
        static void Main(string[] args) {
            double a = 1.0f;
            double b = -5.0f;
            double c = 0.0f;
            Console.WriteLine("({0})*x*x + ({1})*x + ({2}) = 0的解为：",a,b,c);
            MyClass.GetGolution(a, b, c);
            Console.ReadKey();
        }
    }
}

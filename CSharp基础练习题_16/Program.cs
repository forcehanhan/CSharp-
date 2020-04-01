/*
 * 时    间：2020年2月27日13:35:12
 * 题    目：16.编一个程序,输入三个实数,要求使用 if else语句把它们的中间数找出来,可以使用逻辑运算符。
 * 知 识 点：
 * 操作步骤：
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp基础练习题_16
{
    class Program
    {
        static void Main(string[] args) {
            MyClass mc = new MyClass();
            float a = 133.33f;
            float b = 1000.33f;
            float c = 13.33f;

            float middle = mc.GetMiddle(a, b, c);

            Console.WriteLine(middle);
            Console.ReadKey();
        }
    }

    class MyClass
    {
        public float GetMiddle(float a, float b, float c) {
            float middle = a;
            if (a < b && b < c)
            {
                middle = b;
            }
            else if (b < a && a < c)
            {
                middle = a;
            }
            else if (a < c && c < b)
            {
                middle = c;
            }
            else
            {
                return middle;
            }
            return middle;
        }
    }
}

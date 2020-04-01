/*
 * 时    间：2020年2月27日13:09:02
 * 题    目：15.编写一个程序，定义三个foat类型的变量，分别从键盘上输入值给它们，
 *          然后用if-else选择语句找出它们中的最小数，最后输出结果。
 * 实现目的：
 * 操作步骤：
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp基础练习题_15
{
    class Program
    {
        static void Main(string[] args) {
            MyClass mc = new MyClass();
            float a = 133.33f;
            float b = 1000.33f;
            float c = 13.33f;

            float res = mc.GetMin(a, b, c);

            Console.WriteLine(res);
            Console.ReadKey();
        }
    }//Program

    class MyClass
    {
        public float GetMin(float a, float b, float c) {
            float min = a;
            if (a < b && a < c)
            {
                min = a;
            }
            else if (b < a && b < c)
            {
                min = b;
            }
            else if (c < a && c < b)
            {
                min = c;
            }
            else
            {
                return min;
            }
            return min;
        }
    }
}

/*
 * 时    间：2020年2月27日20:56:28
 * 题    目：20.编一个程序,用whi1e循环语句来计算1+1/2+2/3+3/4+...+99/100之和
 * 知 识 点：
 * 操作步骤：
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp基础练习题_20
{
    class Program
    {
        static void Main(string[] args) {
            int n = 99;
            MyClass mc = new MyClass();
            float res = mc.GetSum(n);
           
            Console.WriteLine("1+ 1/2 + 2/3 + 3/4 + ... + 99/100 = " + res);
            Console.ReadKey();
        }
    }

    class MyClass
    {
        public float GetSum(int n) {
            
            int i = 0;
            float result = 0.0f;
            if (n == 1)
            {
                result = 1.0f;
            }
            if (n > 0)
            {
                while (n < 100)
                {
                    result += (float)n / (float)(n + 1);
                    n++;
                }
            }
            return result+1;
        }
    }
}

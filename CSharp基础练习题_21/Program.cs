/*
 * 时    间：2020年2月27日23:01:43
 * 题    目：编一个程序，用 do-while循环语句来计算p = 4 * (1-1/3+1/5-1/7+1/9+...+1/n)，要求当1/n < 0.000001时停止计算。
 * 实现目的：
 * 操作步骤：
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp基础练习题_21
{
    class Program
    {
        static void Main(string[] args) {
            MyClass mc = new MyClass();
            double PI = mc.GetSum(500000);
            Console.WriteLine(" π = " + PI);
            Console.ReadKey();
        }
    }
    class MyClass
    {
        public double GetSum(int n) {
            int i = 1;
            double res;

            double sum = 0.0f;
            double PI;
            do
            {
                res = Math.Pow((-1), i + 1) / (2 * i - 1);
                sum += res;
                i++;
            }/* while (i < 500000);*/while ((double)1 / (2*i-1) > 0.000001);

            PI = 4 * sum;
            return PI;
        }
    }
}
/*
 结果：
 π = 3.14159065358969
     
     */

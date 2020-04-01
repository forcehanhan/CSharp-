/*
 * 时间：2020年2月26日22:25:25
 * 题目：11.编一个程序，定义一个实数变量，从键盘上输入一个值如果这个值在闭区间[0,100]里，则加上100，否则不加。最后输出结果。
 * 实现目的：
 * 操作步骤：
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp基础练习题_11
{
    class Program
    {
        static void Main(string[] args) {
            Console.Write("请输入一个整数：");
            string str = Console.ReadLine();
            int val = Convert.ToInt32(str);
            MyClass mc = new MyClass();
            val = mc.GetVal(val);
            Console.WriteLine("val = " + val);
            Console.ReadKey();
        }
    }
    class MyClass
    {
        public int GetVal(int val) {
            if (val >= 0 && val <= 100)
            {
                val += 100;
                return val;
            }
            else
            {
                return val;
            }
        }
    }
}

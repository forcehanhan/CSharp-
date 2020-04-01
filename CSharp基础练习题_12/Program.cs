/*
 * 时    间：
 * 题    目：12.编一个程序，输入一个整数使用if-else语句，如果该数大于0，则加上100，否则加上500输出结果。
 * 实现目的：
 * 操作步骤：
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp基础练习题_12
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
            if (val >= 0)
            {

                return val += 100;
            }
            else
            {
                return val += 500;
            }
        }
    }
}
/*
 请输入一个整数：-3
val = 497

    请输入一个整数：2
val = 102
     */


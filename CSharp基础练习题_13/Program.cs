/*
 * 时    间：
 * 题    目：13.编一个程序，用if-else语句输入一个整数，如果该数大于0，则输出"这个数大于零。"，
 *          如果该数等于0，则输出“这个数等于零。"，否则输出“这个数小于零。”。
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
            mc.GetVal(val);

            Console.ReadKey();
        }
    }
    class MyClass
    {
        public void GetVal(int val) {
            if (val > 0)
            {
                Console.WriteLine("这个数大于零。");
            }
            else if (val == 0)
            {
                Console.WriteLine("这个数等于零。");
            }
            else
            {
                Console.WriteLine("这个数小于零。");
            }
        }
    }
}



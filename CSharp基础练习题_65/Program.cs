/*
 * 时    间：2020年3月6日11:40:27
 * 题    目：65.编一个程序，输入一个整数，判定它为几位数。例如，99是2位数，-100是3位数。
 * 知 识 点：
 * 操作步骤：
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp基础练习题_65
{
    class Program
    {
        static void Main(string[] args) {
            Console.Write("请输入一个整数：");
            string str = Console.ReadLine();
            int number = int.Parse(str);
            int temp = number;
            int i = 0; 
            if (number == 0)
            {
                i = 1;
                Console.WriteLine("{0}是{1}位数。", temp, i);
            }
            else
            {
                while (number != 0)
                {
                    number /= 10;
                    i++;
                    if (number == 0)
                    {
                        break;
                    }
                }
                Console.WriteLine("{0}是{1}位数。", temp, i);
            }
            Console.ReadKey();
        }
    }
}
//请输入一个整数：321
//321是3位数。

//请输入一个整数：321
//321是3位数。

//请输入一个整数：321
//321是3位数。
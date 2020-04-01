/*
 * 时    间：2020年3月2日11:16:20
 * 题    目：编一个程序，输入一个正整数，判断它是否为素数，如不是，则输出其所有正约数。
 * 知 识 点：
 * 操作步骤：
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp基础练习题_58
{
    class Program
    {
        static void Main(string[] args) {
            int num = 12;
            bool isPrime = false;
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    isPrime = true;
                    break;
                }
            }
            if (isPrime != true)
            {
                Console.WriteLine("是素数！");
            }
            else
            {
                Console.WriteLine("不是素数！");
                Console.WriteLine("它的正约数有：");
                for (int j = 1; j <= num; j++)
                {
                    if (num % j == 0)
                    {
                        int remainder = num / j;
                        Console.Write("{0} ", remainder);
                    }
                }
            }
            Console.ReadKey();
        }
    }

}

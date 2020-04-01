/*
 * 时    间：2020年3月3日13:40:01
 * 题    目：60.编一个程序，输入一个正整数n，把它转换为二进制数，并输出。提示:应该利用数组。
 * 知 识 点：
 * 操作步骤：
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp基础练习题_60
{
    class Program
    {
        static void Main(string[] args) {
            Console.Write("请输入一个正整数：");
            int n = int.Parse(Console.ReadLine());

            int[] binary = new int[32];
            int m;
            int i = 0;
            if (n == 0)
            {
                Console.WriteLine(0);
            }
            else if (n < 0)
            {
                Console.WriteLine("输入的数字应该为正整数。");
                return;
            }
            else
            {
                while (n > 0)
                {
                    binary[++i] = n % 2;
                    n /= 2;
                }
            }

            for (int j = i; j > 0; j--)
            {
                Console.Write(binary[j]);
            }
            Console.ReadKey();
        }//Main()
       
    }//Program
}
//请输入一个正整数：11
//0101

/*
 * 时    间：2020年2月29日20:29:57
 * 题    目：36.编一个程序,利用二重for循环语句，打印出九九乘法口诀表。
 * 知 识 点：
 * 操作步骤：
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp基础练习题_36
{
    class Program
    {
        static void Main(string[] args) {
            Console.WriteLine("-----------------------------九九乘法表--------------------------------------");
            for (int i = 1; i <= 9; i++)
            {
                
                for (int j = 1; j <= i; j++)
                {
                   
                    int s = i * j;
                    Console.Write("{1}*{0}={2,2}  ", i,j,s);
                    if (i == j)
                    {
                        Console.WriteLine();
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("---------------------------------------------------------------------------");
            Console.ReadKey();
        }
    }
}

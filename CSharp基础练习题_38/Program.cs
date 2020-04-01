/*
 * 时    间：2020年2月29日20:56:26
 * 题    目：编一个程序，利用for循环语句，求出1!+2!+3+...+10!的和。
 * 知 识 点：
 * 操作步骤：
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp基础练习题_38
{
    class Program
    {
        static void Main(string[] args) {
            int product = 1;
            int sum = 0;
            for (byte i = 1; i <= 10; i++)
            {
                product *= i;
                sum += product;
            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
//4037913

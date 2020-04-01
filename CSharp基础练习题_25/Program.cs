/*
 * 时    间：2020年2月28日00:10:50
 * 题    目：25.编写一个程序，用while语句，求出1+(1+2)+(1+2+3)+…+(1+2+3+，+10)之和。
 * 知 识 点：
 * 操作步骤：
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp基础练习题_25
{
    class Program
    {
        static void Main(string[] args) {
            int n =1;
            int s1 = 0;
            int s2 = 0;
            if (n > 0)
            {
                while (n <= 10)
                {
                    s1 += n;
                    s2 += s1; 
                    n++;
                }
            }

            Console.WriteLine("Sum = "+s2);
            Console.ReadKey();
        }
    }
}

//Sum = 220

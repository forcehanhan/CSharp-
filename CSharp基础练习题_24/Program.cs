/*
 * 时    间：2020年2月27日23:51:56
 * 题    目：24.编一个程序，打印出所有的“水仙花数”，所谓“水仙花数”是指一个三位数，其各位数字立方和等于该数本身。
 *              例如，153=1*1*1+5·5*5+3*3*3，所以153是“水仙花数”。
 * 知 识 点：
 * 操作步骤：
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp基础练习题_24
{
    class Program
    {
        static void Main(string[] args) {
            //int num ;
            int a;//百位
            int b;//十位
            int c;//个位
            Console.WriteLine("100~999之间的水仙花数：");
            for (int num = 100; num < 1000; num++)
            {
                c = num % 10;

                b = num / 10;
                b %= 10;

                a = num / 100;
                a %= 10;
                if (num == (a * a * a + b * b * b + c * c * c))
                {
                    Console.Write("\t" + num);
                }
            }
            Console.ReadKey();

        }
    }
}

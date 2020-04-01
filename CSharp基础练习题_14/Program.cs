/*
 * 时    间：
 * 题    目：14.编一个程序，输入一个正数，对该数进行四舍五入到个位数的运算。
 *              例如，实数12.56经过四舍五入运算，得到结果13；而12.46经过四舍五入运算，得到结果12。
 * 实现目的：
 * 操作步骤：
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp基础练习题_14
{
    class Program
    {
        static void Main(string[] args) {
            /*第一种方法：*/
            float val = 1002.56f;
            //float val = 112.46f;
            float temp = val;
            val = (float)val * 10;
            int num1 = (int)val % 10;
            if (num1 >= 5)
            {
                temp += 1;
                val = temp;
            }
            else
            {
                val = temp;
            }
            Console.WriteLine((int)val);


            /*第二种方法：*/
            //double val1 = 12.56f;
            //double val2 = 12.46f;
            //val1 = Math.Round(val1);
            //val2 = Math.Round(val2);
            //Console.WriteLine(val1);
            //Console.WriteLine(val2);

            /*第三种方法*/
            //Console.WriteLine(string.Format("{0:N0}", 12.56));//四舍五入格式输出符
            Console.ReadKey();
        }
    }
}

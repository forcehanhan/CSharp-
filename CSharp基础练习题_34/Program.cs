/*
 * 时    间：2020年2月29日18:40:55
 * 题    目：34.编一个程序，用whe循环语句实现下列功能:
 *              有一篮鸡蛋，不止一个，有人两个两个数，多余一个; 三个三个数，多余一个;再四个四个地数，也多余一个。请问这篮鸡蛋至少有多少个？
 * 知 识 点：
 * 操作步骤：
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp基础练习题_34
{
    class Program
    {
        static void Main(string[] args) {
            int n = 3;
            //n % 2 = 1
            //n % 3 = 1
            //n % 4 = 1
            bool is234 = false;
            while (n < 100)
            {
                is234 = false;
                if (n % 2 == 1 && n % 3 == 1 && n % 4 == 1)
                {
                    is234 = true;
                   
                }
                if (is234)
                {
                    Console.WriteLine(n);
                    //break;
                }
                n++;
            }
            Console.ReadKey();
        }
    }
}

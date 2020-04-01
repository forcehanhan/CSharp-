/*
 * 时    间：2020年2月27日18:15:44
 * 题    目：19.编一个程序,利用do-whi1e循环语句,从键盘上输入10个整数,求出它们的和。
 * 知 识 点：
 * 操作步骤：
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp基础练习题_19
{
    class Program
    {
        static void Main(string[] args) {
            int[] num = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int i = 0;
            int temp = 0;
            do
            {
                temp += num[i];
                i++;
            } while (i < 10);
            Console.WriteLine(temp);
            Console.ReadKey();
        }
    }
}

/*
 * 时    间：2020年3月1日19:20:43
 * 题    目：48.编一个程序，从键盘输入一个字符串，用foreach语句，统计其中大写字母的个数和小写字母的个数。
 * 知 识 点：
 * 操作步骤：
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp基础练习题_48
{
    class Program
    {
        static void Main(string[] args) {
            string str = "abcdABCD";
            int i = 0;
            int j = 0;
            foreach (char item in str)
            {
                //Console.WriteLine(item);
                if (item >= 'a' && item <= 'z')
                {
                    i++;
                }
                else if (item >= 'A' && item <= 'Z')
                {
                    j++;
                }
                else
                {
                    continue;
                }
            }
            Console.WriteLine("小写字母有 {0} 个，大写字母有 {1} 个",i,j);
            Console.ReadKey();
        }
    }
}

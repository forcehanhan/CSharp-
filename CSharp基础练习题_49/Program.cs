/*
 * 时    间：2020年3月1日19:45:41
 * 题    目：49.编一个程序，定义一个字符数组和一个字符串变量，给这个字符串变量输入一个字符串，
 *              然后用 foreach语句把这个字符串拷贝到字符数组里，最后输出字符数组。
 * 知 识 点：
 * 操作步骤：
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp基础练习题_49
{
    class Program
    {
        static void Main(string[] args) {

            Console.Write("请输入字符串：");
            string str = Console.ReadLine();
            int strLenth = str.Length;
            char[] character = new char[strLenth];

            int i = 0;
            foreach (char item in str)
            {
                character[i] = item;
                i++;
            }

            foreach (char ch in character)
            {
                Console.WriteLine("{0}", ch);
            }
            Console.ReadKey();
        }
    }
}
/*
请输入字符串：string
s
t
r
i
n
g
*/

/*
 * 时    间：2020年3月1日21:01:39
 * 题    目：51.编一个程序，输入一个字符串，用ToCharArray方法把字符串中的内容拷贝到字符数组中，然后用foreach输出该字符数组。
 * 知 识 点：
 * 操作步骤：
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp基础练习题_51
{
    class Program
    {
        static void Main(string[] args) {
            string str = "string";
            int strLenth = str.Length;
            char[] character = new char[strLenth];
            character = str.ToCharArray();
            foreach (char ch in character)
            {
                Console.Write("   " + ch);
            }

            Console.ReadKey();
        }
    }
}
/*   s   t   r   i   n   g*/

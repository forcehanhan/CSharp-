/*
 * 时    间：
 * 题    目：52.编一个程序，定义一个字符串变量，输入字符串，然后再输入一个字符，在字符串中查找该字符出现的次数。
 * 知 识 点：
 * 操作步骤：
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp基础练习题_52
{
    class Program
    {
        static void Main(string[] args) {
            string str = "string-string-string";
            Char c = 's';
            int i = 0;
            foreach (char ch in str)
            {
                if (ch == c)
                {
                    i++;
                }
            }
            Console.WriteLine("{0}出现的次数为{1}",c,i);
            Console.ReadKey();
        }
    }
}
//s出现的次数为3

/*
 * 时    间：2020年3月1日20:19:45
 * 题    目：50.输入一个字符串，将其中小写字母改成大写字母，把大写字母改成小写字母，其余字符不变，输出该字符串。
 * 知 识 点：
 * 操作步骤：
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp基础练习题_50
{
    class Program
    {
        static void Main(string[] args) {
            Console.WriteLine("Please input string:");
            string str = Console.ReadLine();
            foreach (char s in str)
            {
                if (s >= 'a' && s <= 'z')
                {
                    Console.Write((char)((int)s-32));
                }
                else if (s >= 'A' && s <= 'Z')
                {
                    Console.Write((char)((int)s + 32));
                }
                else
                {
                    continue;
                }
            }
            Console.ReadKey();
        }
    }
}

//Please input string:
//StringGnirts
//sTRINGgNIRTS

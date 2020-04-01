/*
 * 时    间：2020年2月26日13:50:24
 * 题    目：6.输入一个字符，判定它是什么类型的字符(大写字母，小写字母，数字或者其它字符)。
 * 实现目的：1、函数功能。 2、判断输入的BUG。 3、程序的健壮性。
 * 操作步骤：
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp基础练习题_06
{
    class Program
    {
        static void Main(string[] args) {
            JudgeClass jc = new JudgeClass();
            Console.Write("请输入一个字符：");
            string str = Console.ReadLine();
            char character = jc.JudgeBug(str);
            Console.ReadKey();
        }//Program

        class JudgeClass
        {
            //判断输入的Bug
            public char JudgeBug(string str) {
                char character;
                while (true)
                {
                    try
                    {
                        character = Convert.ToChar(str);
                        while (true)
                        {
                            if (character >= 'A' && character <= 'Z')
                            {
                                Console.WriteLine("大写字母。");
                            }
                            else if (character >= 'a' && character <= 'z')
                            {
                                Console.WriteLine("小写字母。");
                            }
                            else if (character >= '0' && character <= '9')
                            {
                                Console.WriteLine("数字。");
                            }
                            else
                            {
                                Console.WriteLine("其它字符。");
                            }
                            Console.Write("请输入一个字符：");
                            str = Console.ReadLine();
                            character = Convert.ToChar(str);
                            //return character;// 如果不想循环输入，这里可以使用return返回。
                        }
                    }
                    catch (Exception)
                    {
                        Console.Write("输入错误，请重新输入一个字符：");
                        str = Console.ReadLine();
                    }
                }
            }//JudgeBug()
        }//JudgeClass
    }//Program
}//NameSpace
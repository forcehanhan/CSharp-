/*
 * 时间：2020年2月26日16:53:36
 * 题目：9.编一个程序，输入一个字符，如果输入的字符是大写字母，则转换为小写字母；如果输入的字符是小写字母，则转换为大写字母，否则不转换。
 * 实现目的：
 * 操作步骤：
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp基础练习题_09
{
    class Program
    {
        static void Main(string[] args) {
            JudgeBugClass jc = new JudgeBugClass();
            Console.Write("请输入一个英文字母：");
            string str = Console.ReadLine();
            char character = jc.JudeChaeacter(str);

            //if (character >= 'A' && character <= 'Z')
            //{
            //    Console.WriteLine("{0}的对应大写字母是{1}", str, character);
            //}
            //else if (character >= 'a' && character <= 'z')
            //{
            //    Console.WriteLine("{0}的对应小写字母是{1}", str, character);
            //}else
            //{
            //    Console.WriteLine("请重新输入。");
            //}

            Console.ReadKey();
        }
    }//Program

    class JudgeBugClass
    {
        public char JudeChaeacter(string str) {
            while (true)
            {
                try
                {
                    char character = Convert.ToChar(str);

                    while (character != null)
                    {
                        if (character >= 'A' && character <= 'Z')
                        {
                            int temp = Convert.ToInt32(character);
                            temp += 32;
                            character = Convert.ToChar(temp);
                            Console.WriteLine("{0}的对应小写字母是{1}", str, character);
                        }
                        else if (character >= 'a' && character <= 'z')
                        {
                            int temp = Convert.ToInt32(character);
                            temp -= 32;
                            character = Convert.ToChar(temp);
                            Console.WriteLine("{0}的对应大写字母是{1}", str, character);
                        }
                        else
                        {
                            Console.WriteLine("不是英文字母，不转换。");
                        }
                        return character;
                    }

                }
                catch (Exception)
                {
                    Console.WriteLine("错误：你输入的不是英文字母或是多个字母，请重新输入。");
                    str = Console.ReadLine();
                }
            }


        }//JudeChaeacter()
    }//JudgeBugClass
}

/*
 * 时间：2020年2月26日00:25:03
 * 题目：5.编一个程序，输入一个字符，如果是大写字母，就转换成小写字母，否则不转换。
 * 实现目的：
 * 操作步骤：
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp基础练习题_05
{
    class JudgeClass
    {
        #region //JudegBug()
        //函数 JudegBug()的作用：
        //1、判断输入的字符串是不是一个字符，如果不是，则重新输入。
        //2、判断输入的字符是不是大写的，如果不是，则重新输入。
        public char JudegBug(string str) {
            char letter;

            while (true)
            {
                try
                {
                    letter = Convert.ToChar(str);
                    if (letter >= 'A' && letter <= 'Z')
                    {
                        return letter;
                    }
                    else
                    {
                        Console.Write("你输入的不是大写字符，重新输入：");
                        str = Console.ReadLine();
                    }
                }
                catch (Exception)
                {
                    Console.Write("输入的字符个数只能是1个，重新输入：");
                    str = Console.ReadLine();
                }
            }
        }
        #endregion

    }//JudgeClass
    class Program
    {
        static void Main(string[] args) {
            JudgeClass jc = new JudgeClass();
            char ch1;
            char ch2;
            Console.Write("请输入一个大写字母：");
            string str = Console.ReadLine();

            ch1 = jc.JudegBug(str);//判断是不是一个字符
            //ch1 = jc.JudgeBigLetter(ch1);//判断是不是大写


            int num2 = Convert.ToInt32(ch1) + 32;
            //Console.WriteLine(num2);
            ch2 = Convert.ToChar(num2);
            Console.WriteLine(ch1 + "的小写字母是" + ch2);
            Console.ReadKey();
        }
    }
}

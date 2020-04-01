/*
 * 时    间：2020年3月7日22:05:21
 * 题    目：77.编写一个类，其中包含一个排序的方法Sort(),当传入的是一串整数，
 * 就按照从小到大的顺序输出，如果传入的是一个字符串，就将字符串反序输出。
 * 知 识 点：
 * 操作步骤：
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp基础练习题_77
{
    class SortClass
    {
        public char[] SortCharacter(char[] num) {

            int i,j;
            bool isNum = true;

            //判断是字符还是数字
            for (i = 0; i < num.Length; i++)
            {
                if (num[i] < '0' || num[i] > '9')
                {
                    isNum = false;
                    break;
                }
                else
                {
                    isNum = true;
                }
            }

            //如果是一串字符，则对其降序排序
            if (isNum == false)
            {
                for (i = 0; i < num.Length; i++)
                {
                    for (j = 1; j < num.Length - i; j++)
                    {
                        if (num[j] > num[j - 1])
                        {
                            char temp = num[j - 1];
                            num[j - 1] = num[j];
                            num[j] = temp;
                        }
                    }
                }
                return num;

            }
            //如果是一串数字，则对其升序排序
            else
            {
                for (i = 0; i < num.Length; i++)
                {
                    for (j = 1; j < num.Length - i; j++)
                    {
                        if (num[j] < num[j - 1])
                        {
                            char temp = num[j - 1];
                            num[j - 1] = num[j];
                            num[j] = temp;
                        }
                    }
                }
                return num;
            }
        }
    }
    class Program
    {
        static void Main(string[] args) {
            Console.Write("请输入一串数字或者字符：");
            string str = Console.ReadLine();
            //将字符串转为字符数组
            char[] num = str.ToCharArray();

            //调用排序函数
            SortClass sc = new SortClass();
            sc.SortCharacter(num);

            //将排序好的字符串打印出来
            for (int i = 0; i < num.Length; i++)
            {
                Console.Write("{0}  ", num[i]);
            }

            Console.ReadKey();
        }
    }
}

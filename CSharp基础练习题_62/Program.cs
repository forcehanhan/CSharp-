/*
 * 时    间：2020年3月4日21:36:03
 * 题    目：62.所谓“回文数”是指读一个自然数，从正方向读和反方向读，结果是一样的。
 *          例如: 646，1551,891232198都认为是回文数。
 *          编一个程序，输入一个正整数，判定它是否为回文数。当输入的数为0时，则退出程序，否则继续循环执行程序。
 * 知 识 点：
 * 操作步骤：
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp基础练习题_62
{
    class Program
    {
        static void Main(string[] args) {

            #region 方法一：

            //while (true)
            //{
            //    Console.Write("请输入一个正整数(输入0则退出)：");
            //    string str = Console.ReadLine();
            //    int palindrome = int.Parse(str);
            //    bool isEqual = false;
            //    if (palindrome > 0)
            //    {
            //        int strlenth = str.Length;
            //        //int[] arrPalindrome = new int[strlenth];
            //        char[] character = str.ToCharArray();
            //        //Console.WriteLine(character.Length);

            //        for (int i = 0; i < character.Length; i++)
            //        {
            //            if (character[i] == character[character.Length - 1 - i])
            //            {
            //                isEqual = true;
            //            }
            //            else
            //            {
            //                isEqual = false;
            //                break;
            //            }
            //        }
            //    }
            //    else if (palindrome == 0)
            //    {
            //        return;
            //    }
            //    else
            //    {
            //        Console.WriteLine("请输入正整数。");
            //    }

            //    if (isEqual == true)
            //    {
            //        Console.WriteLine("是回文数。");
            //    }
            //    else
            //    {
            //        Console.WriteLine("不是回文数。");
            //    }
            //}//while

            #endregion



            #region 方法二
            while (true)
            {
                ////////输入数字//////
                Console.Write("请输入一个正整数(输入0则退出)：");
                string str = Console.ReadLine();
                int strlenth = str.Length;
                int palindrome = int.Parse(str);

                int[] arrPal = new int[strlenth];

                bool isEqual = false;
                int i = 0;
                int j = 0;
                ///////标记/////////////////
                if (palindrome > 0)
                {
                    //回去各位的数字
                    for (i = 0; i < arrPal.Length; i++)
                    {
                        arrPal[i] = palindrome % 10;
                        palindrome /= 10;
                    }

                    //判断是否是回文数
                    for (j = 0; j < (arrPal.Length+1 ) / 2; j++)
                    {
                        if (arrPal[j] == arrPal[arrPal.Length - 1 - j]) 
                        {
                            isEqual = true;
                        }
                        else
                        {
                            isEqual = false;
                        }
                    }
                }
                else if (palindrome == 0)
                {
                    return;
                }
                else
                {
                    Console.WriteLine("请输入正整数。");
                }
                //////////判断结果////////////
                if (isEqual == true)
                {
                    Console.WriteLine("是回文数。");
                }
                else
                {
                    Console.WriteLine("不是回文数。");
                }

            }


            Console.ReadKey();
            #endregion
        }
    }
}
/*
 请输入一个正整数(输入0则退出)：891232198
是回文数。
请输入一个正整数(输入0则退出)：12321
是回文数。
请输入一个正整数(输入0则退出)：646
是回文数。
请输入一个正整数(输入0则退出)：1
是回文数。
请输入一个正整数(输入0则退出)：

     
     */

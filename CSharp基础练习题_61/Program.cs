/*
 * 时    间：2020年3月3日16:20:04
 * 题    目：61.所谓“降序数”是指一个自然数的低位数字不大于高位数字的数。
 *              例如: 64, 55，321都认为是降序数，但是623不是降序数。
 *              一位数字被认为是降序数。编一个程序，输入一个数，判定它是否为降序数。
 *              该程序是循环执行的，当输入的数为0时，则退出程序运行。
 * 知 识 点：
 * 操作步骤：
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp基础练习题_61
{
    class Program
    {
        static void Main(string[] args) {

            while (true)
            {
                Console.Write("请输入一个数，如果退出，请输入0：");
                string str = Console.ReadLine();
                int len = str.Length;
                int[] descend = new int[len];
                int des = int.Parse(str);//降序

                int temp = des;
                bool isDescend = false;
                #region 标记isDescend
                if (des == 1)
                {
                    isDescend = true;
                    //Console.WriteLine("{0}是降序数 ", temp);
                }
                else if (des == 0)//输入0退出
                {
                    return;
                }
                else
                {
                    for (int i = 0; i < descend.Length; i++)
                    {

                        descend[i] = des % 10;
                        des = des / 10;
                    }

                    for (int j = 1; j < descend.Length; j++)
                    {
                        if (descend[j] > descend[j - 1])
                        {
                            isDescend = true;
                        }
                        else
                        {
                            isDescend = false;
                        }
                    }
                }
                #endregion

                #region 判断是不是降序数
                if (isDescend == true)
                {
                    Console.WriteLine("{0}是降序数 ", temp);
                }
                else
                {
                    Console.WriteLine("{0}不是降序数 ", temp);
                }
                #endregion
            }
            //Console.ReadKey();
        }//Main
    }
}

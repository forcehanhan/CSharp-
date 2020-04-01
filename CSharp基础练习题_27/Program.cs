/*
 * 时    间：2020年2月28日23:10:55
 * 题    目：27.编一一个程序,用while循环语句,从键盘输入10个数,要求找出最大数和次大数。
 * 知 识 点：
 * 操作步骤：
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp基础练习题_27
{
    class Program
    {
        static void Main(string[] args) {
            int[] arr = new int[] { 11, 2, 3, 3, 8, 7, 4, 5, 9, 1, 3 };
            //int[] arr = new int[] { 11, 2, 3, 4, 5, 6, 7, 8, 9, 10, 2, 1 };

            int max1 = 0;
            int max2 = 0;

            //求最大数
            int i = 0;
            while (i < arr.Length)
            {
                if (max1 < arr[i])
                {
                    max2 = max1;
                    max1 = arr[i];
                }
                //求次于最大数的数
                else if (max2 < arr[i])
                {
                    max2 = arr[i];
                }
                i++;
            }
            Console.WriteLine("Max = " + max1);
            Console.WriteLine("Sec = " + max2);



            #region////求最大数和次大数--用排序
            /*
            int j = 0;
            while (j < arr.Length-1 )
            {
                int i = 0;
                while (j <arr.Length-i-1)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        int temp = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = temp;
                    }
                    i++;
                }
               j++;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            max = arr[9];
            sec = arr[8];
            Console.WriteLine("Max = " + max);
            Console.WriteLine("Sec = " + sec);
            */
            #endregion
            Console.ReadKey();
        }
    }
}

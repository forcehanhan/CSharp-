/*
 * 时    间：2020年2月29日23:59:08
 * 题    目：45.编一个程序,从键盘输入10个实数,存入一个数组,用冒泡法对这个数作升序排序。
 * 知 识 点：
 * 操作步骤：
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp基础练习题_45
{
    class Program
    {
        //冒泡排序
        static void Main(string[] args) {
            int[] arr = new int[] { 1, 4, 7, 8, 5, 2, 3, 6, 9, 0 };
            int temp = arr[0];
            for (int j = 1; j <= arr.Length; j++)
            {
                for (int i = 1; i <= arr.Length - j; i++)//i <= arr.Length - j 想一想它的含义
                {
                    if (arr[i] < arr[i - 1])
                    {
                        temp = arr[i];
                        arr[i] = arr[i - 1];
                        arr[i - 1] = temp;
                    }
                }
            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.ReadKey();
        }
    }
}

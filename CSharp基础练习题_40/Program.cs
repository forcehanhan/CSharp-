/*
 * 时    间：2020年2月29日21:30:36
 * 题    目：40.编一个程序，用for循环语句， 从键盘输入10个实数，分别求出它们中的正数之和，以及负数之和。
 * 知 识 点：
 * 操作步骤：
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp基础练习题_40
{
    class Program
    {
        static void Main(string[] args) {
            int[] arr = new int[] { 10, -10, 20, -20, 30, -30, 50, -50, 60, -61 };
            int s1 = 0;
            int s2 = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    s1 += arr[i];
                }
                else
                {
                    s2 += arr[i];
                }
            }
            Console.WriteLine("负数之和 = {0},正数之和 = {1}",s1,s2);
            Console.ReadKey();
        }
    }
}

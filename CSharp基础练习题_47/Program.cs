/*
 * 时    间：2020年3月1日19:07:20
 * 题    目：47.编一个程序，定义一个数组，用for语句输入10个实数存入这个数组，然后按逆序重新存放后再输出。        
 * 知 识 点：
 * 操作步骤：
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp基础练习题_47
{
    class Program
    {
        static void Main(string[] args) {

            int[] arr = new int[10];
            int i = 0;
            Console.WriteLine("请输入数字，不超过10个：");
            for (i = 0; i < arr.Length; i++)
            {
                Console.Write("请在此输入：");
                string str = Console.ReadLine();
                    arr[i] = int.Parse(str); 
            }
            for (int j = 0; j < arr.Length; j++)
            {
                for (int k = 1; k < arr.Length - j; k++)
                {
                    if (arr[k-1]<arr[k])
                    {
                        int temp = arr[k - 1];
                        arr[k - 1] = arr[k];
                        arr[k] = temp;
                    }
                }
            }
            for (i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("{0}", arr[i]);
            }
            Console.ReadKey();
        }
    }
}

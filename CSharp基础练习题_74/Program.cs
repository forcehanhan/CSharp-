/*
 * 时    间：2020年3月7日10:39:36
 * 题    目：74.编一个程序，定义一个数组,再定义类以及方法，用方法(out参数传递数据)找出这组数据中的最大数和最小数。
 * 知 识 点：1、out参数传出数据。 2、out和函数的返回值没有直接打关系。
 * 操作步骤：
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp基础练习题_74
{
    class MyClass
    {
        public void GetMinAndMax(int[]arr,out int min,out int max) {
            int i = 0;
            max = arr[0];
            min = arr[0];
            for (i = 0; i < arr.Length; i++)
            {
                if (max < arr[i])
                {
                    max = arr[i];
                }
                else
                {
                    min = arr[i];
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args) {
            int[] arr = new int[10] { 10, 9, 20, 11, 55, 88, 0, 19, 6, 8 };
            int max, min;
            MyClass mc = new MyClass();
            mc.GetMinAndMax(arr, out min, out max);
            Console.WriteLine("min = {0}, max = {1}", min, max);
            Console.ReadKey();
        }
    }
}

/*min = 8, max = 88*/

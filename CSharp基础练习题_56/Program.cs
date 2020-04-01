/*
 * 时    间：2020年3月2日00:09:22
 * 题    目：56.定义一个一维数组，输入任意6个整数，假定为7, 4，8，9，1, 5。编一个程序，利用for语句， 输出如下方阵的内容:
            7　4　8　9　1　5
            5　7　4　8　9　1
            1　5　7　4　8　9
            9　1　5　7　4　8
            8　9　1　5　7　4
            4　8　9　1　5　7
 * 知 识 点：
 * 操作步骤：
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp基础练习题_56
{
    class Program
    {
        static void Main(string[] args) {
            int[] arr = new int[] { 7, 4, 8, 9, 1, 5 };
            for (int i = 0; i < arr.Length; i++)
            {
                if (i == 0)
                {
                    for (int j = 0; j < arr.Length; j++)
                    {
                        Console.Write("{0}  ", arr[j]);
                    }
                    Console.WriteLine();
                    continue;
                }
                else
                {
                    for (int j = 0; j < arr.Length; j++)
                    {
                        int temp = arr[j];
                        arr[j] = arr[arr.Length - 1];
                        arr[arr.Length - 1] = temp;
                        Console.Write("{0}  ", arr[j]);
                    }
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
//7  4  8  9  1  5
//5  7  4  8  9  1
//1  5  7  4  8  9
//9  1  5  7  4  8
//8  9  1  5  7  4
//4  8  9  1  5  7


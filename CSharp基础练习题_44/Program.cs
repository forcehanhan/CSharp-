/*
 * 时    间：2020年2月29日23:18:27
 * 题    目：44.编一个程序,定义数组,用for循环语询,顺序输入10个实数,然后逆序输出这10个数。
 * 知 识 点：
 * 操作步骤：
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp基础练习题_44
{
    class Program
    {
        static void Main(string[] args) {
            int[] arr = new int[] { 1,2,3,6,5,4,9,8,7,10 };
            int temp = arr[0];

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("arr[{0}] = {1,-2}", i, arr[i]);
            }

            Console.WriteLine("----------------------------------");

            /*i < arr.Length-5:实际上，只需要交换5次就可以了。
             * 分析：
             * 最面的数 与 最后面的数对换，
             * arr[0]→arr[9]
             * arr[1]→arr[8]
             * arr[2]→arr[7]
             * arr[3]→arr[6]
             * arr[4]→arr[5]
             * arr[5]→arr[4]不需要换
             * arr[6]→arr[3]不需要换
             * arr[7]→arr[2]不需要换
             * arr[8]→arr[1]不需要换
             * arr[9]→arr[0]不需要换
            */
            for (int i = 0; i < arr.Length-5; i++)
            {
                temp = arr[i];
                arr[i] = arr[arr.Length-1-i];
                arr[arr.Length-1-i] = temp;
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("arr[{0}] = {1,-2}", i, arr[i]);
            }

            Console.ReadKey();
        }
    }
}

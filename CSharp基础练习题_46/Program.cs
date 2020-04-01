/*
 * 时    间：2020年3月1日19:04:46
 * 题    目：46.编一个程序，定义一个有10个元素的一维数组a,在键盘上输入时没有大小次序,
 *              但是存入数组时要按由小到大的顺序存放。例如，输入第1个数1时,存入a[0];假如第2个数是5，
 *              则数存入a[1];假如第3个数是4，那么把前面输入的5向后面移动到a[2],把4插入到a[1]的位置上，
 *              这样使得每输入一个数，保持从小到大的顺序排列。
 * 知 识 点：
 * 操作步骤：
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp基础练习题_46
{
    class Program
    {
        static void Main(string[] args) {
            MyClass mc = new MyClass();
            int[] a = new int[10];
            int n = 1;
            int m = 0;
            Console.WriteLine("请输入数字，不超过10个，如果想结束，请输入n：");
            for (m = 0; m < n; m++,n++)
            {
                Console.Write("请在此输入：");
                string str = Console.ReadLine();
                if (str == "n")
                {
                    break;
                }
                else
                {
                    a[m] = int.Parse(str);
                }
            }
            mc.SortArray(a, m);
            Console.ReadKey();
        }
    }//Program

    class MyClass
    {
        public void SortArray(int[] a,int n) {
            int temp = a[0];
            for (int i = 0; i < n; i++)
            {
                for (int j = 1; j < n - i; j++)
                {
                    if (a[j - 1] > a[j])
                    {
                        temp = a[j - 1];
                        a[j - 1] = a[j];
                        a[j] = temp;
                    }
                }
            }
            Console.WriteLine("你输入的数字是（由小到大）：");
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != 0)
                {
                    Console.WriteLine("a[{0}] = {1}", i, a[i]);
                }

            }
        }
    }
}

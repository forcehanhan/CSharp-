/*
 * 时    间：2020年2月29日12:14:14
 * 题    目：33.编一个程序，利用whie循环语句，找出2到100之间的素数。
 *          （质数又称素数。一个大于1的自然数，除了1和它自身外，不能被其他自然数整除的数叫做质数；否则称为合数。）
 * 知 识 点：
 * 操作步骤：
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp基础练习题_33
{
    class Program
    {
        static void Main(string[] args) {
            MyClass mc = new MyClass();
            mc.GetPrimie();

            //while循环
            //int n = 2;
            //int i = 2;
            //bool isPrime = false;
            //while (n <= 100)
            //{
            //    isPrime = false;
            //    i = 2;
            //    while (i <= n - 1)
            //    {
            //        if (n % i == 0)
            //        {
            //            isPrime = true;
            //            break;
            //        }
            //        i++;
            //    }

            //    if (!isPrime)
            //    {
            //        Console.WriteLine(n);
            //    }
            //    n++;
            //}

            //for循环
            //int n = 2;
            //int i = 2;
            //bool isPrime = false;
            //for (n = 2; n <= 100; n++)
            //{
            //    isPrime = false;
            //    i = 2;
            //    for (i = 2; i <= n-1; i++)
            //    {
            //        if (n % i == 0)
            //        {
            //            isPrime = true;
            //            break;
            //        }
            //    }


            //    if (!isPrime)
            //    {
            //        Console.WriteLine(n);
            //    }
            //}




            Console.ReadKey();
        }
    }//Program


    class MyClass
    {
        public void GetPrimie() {
            int n = 2;
            int i = 2;
            bool isPrime = false;
            for (n = 2; n <= 100; n++)
            {
                isPrime = false;
                i = 2;
                for (i = 2; i < n; i++)//始终保持n > i,如3%2、4%3、5%4、6%5，而不是3%3、4%4、5%5、6%6
                {
                    if (n % i == 0)
                    {
                        isPrime = true;
                        break;
                    }
                }


                if (!isPrime)
                {
                    Console.WriteLine(n);
                }
            }

        }
    }//MyClass

}


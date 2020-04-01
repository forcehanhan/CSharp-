/*
 * 时    间：2020年3月6日20:44:36
 * 题    目：71.编一个程序，利用自定义方法，找出2到100之间的素数。
 * 知 识 点：
 * 操作步骤：
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp基础练习题_71
{
    class Program
    {
        static void Main(string[] args) {
            int n;
            int i = 0;
            int j = 0;
            bool isPrime = false;

            Console.WriteLine("2到100之间的素数:");
            for (i = 2; i <= 100; i++)
            {
                for (j = 2; j < i; j++)
                {
                    //如果余数为0，则不是素数。2是正整数中最小的素数。
                    if (i % j == 0)
                    {
                        isPrime = true;
                        break;
                    }
                    else
                    {
                        //如果余数不为0，则是素数
                        isPrime = false;
                    }
                }
                //如果满足isPrime！=true，则打印出素数。
                
                if (!isPrime)
                {
                    Console.Write("{0}  ",i);
                }
            }
            Console.ReadKey();
        }
    }
}
/*
2到100之间的素数:
2  3  5  7  11  13  17  19  23  29  31  37  41  43  47  53
59  61  67  71  73  79  83  89  97
*/
/*
 * 时    间：2020年2月29日09:47:19
 * 题    目：30.编写一个程序,要求用while循环语句,打印1到100的正整数,每行打印5个数,每列右对齐。
 * 知 识 点：格式输出符
 * 操作步骤：
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp基础练习题_30
{
    class Program
    {
        static void Main(string[] args) {
            Console.WriteLine("打印1到100的正整数,每行打印5个数,每列右对齐:");
            int i = 1;

            while (i<=100)
            {

                Console.Write("{0, 8}", i);
                if (i % 5 == 0)
                {
                    Console.WriteLine();
                }
                i++;
                
            }
            Console.ReadKey();
        }
    }
}
/*
打印1到100的正整数,每行打印5个数,每列右对齐:
       1       2       3       4       5
       6       7       8       9      10
      11      12      13      14      15
      16      17      18      19      20
      21      22      23      24      25
      26      27      28      29      30
      31      32      33      34      35
      36      37      38      39      40
      41      42      43      44      45
      46      47      48      49      50
      51      52      53      54      55
      56      57      58      59      60
      61      62      63      64      65
      66      67      68      69      70
      71      72      73      74      75
      76      77      78      79      80
      81      82      83      84      85
      86      87      88      89      90
      91      92      93      94      95
      96      97      98      99     100
      */
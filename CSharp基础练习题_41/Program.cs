/*
 * 时    间：2020年2月29日21:56:45
 * 题    目：41.编一个程序，把一张1元的钞票换成5分，2分和1分的硬币，
 *              要求每种至少一枚，并且所换硬币数不超过30枚。请问，有哪几种换法?
 * 知 识 点：
 * 操作步骤：
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp基础练习题_41
{
    class Program
    {
        static void Main(string[] args) {
            //int rmb = 100;//1元=100分
            //100=5*x+2*y+z
            //x+y+z <= 30
            int x = 0;//5分
            int y = 0;//2分
            int z = 0;//1分
            int sum = 0;
            Console.WriteLine("\t5分\t2分\t1分");
            Console.WriteLine("\t-------------------");
            for (x = 1; x <= 20; x++)
            {
                for (y = 1; y <= 50; y++)
                {
                    for (z = 0; z <= 100; z++)
                    {
                        if (5 * x + 2 * y + z == 100 && x + y + z <= 30)
                        {
                            Console.WriteLine("\tx={0}枚\ty={1}枚\tz={2}枚", x, y, z);
                            sum++;

                        }
                    }
                   

                }
            }
            Console.WriteLine("\t一种有{0}种方法。", sum);
            Console.ReadKey();
        }
    }
}
//for (x = 1; x <= 20; x++)
//            {
//                for (y = 1; y <= 50; y++)
//                {
//                    z = 30 - (x + y);
//                    if (5 * x + 2 * y + z <= 100)
//                    {
//                        Console.WriteLine("x={0},y={1},z={2}", x, y, z);
//                        sum++;

//                    }
//                }
//            }

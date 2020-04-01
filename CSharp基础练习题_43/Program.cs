/*
 * 时    间：2020年2月29日23:17:38
 * 题    目：43.编一个程序，解决百钱买百鸡问题：
 *          某人有100元钱，要买100只鸡，公鸡5元钱一只，母鸡3元钱一只，小鸡1元钱3只。
 *          问可买到公鸡，母鸡，小鸡各为多少只？
            问题分析：
            设公鸡x只，母鸡y只，小鸡z只，可以列出两个方程
            x+y+z=100
            5x+3y+z/3=100
            我们采用“穷举法”来解决此问题。
 * 知 识 点：
 * 操作步骤：
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp基础练习题_43
{
    class Program
    {
        static void Main(string[] args) {

            //x + y + z = 100
            //5x + 3y + z / 3 = 100
            int x = 0;//最大取20
            int y = 0;//最大取33
            int z = 0;//最大取300
            int sum = 0;

            for (x = 1; x <= 20; x++)
            {
                for (y = 1; y <= 33; y++)
                {
                    z = 100 - x - y;
                    if (15 * x + 9 * y + z == 300)
                    {
                        Console.WriteLine("x={0},y={1},z={2}", x, y, z);
                        sum++;
                    }
                }
            }
            Console.WriteLine("一种有{0}种解。", sum);//一种有3种方法
            Console.ReadKey();
        }
    }
}
//x=4,y=18,z=78
//x=8,y=11,z=81
//x=12,y=4,z=84
//一种有3种解。

/*
 * 时    间：2020年2月29日23:05:20
 * 题    目：42.编一个程序，把一张面值100元的钞票换成5元，1元和5角面值的钞票，
 *              要求100元换以上的零钱100张，且要求每种不少于一张请问，有哪几种换法?
 * 知 识 点：
 * 操作步骤：
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp基础练习题_42
{
    class Program
    {
        static void Main(string[] args) {
            //int rmb = 100;//100元软妹币
            //5元，1元，5角
            //5*x+1*y+0.5*z <= 100元 <=> 25*x+2*y+z <= 500
            //x+y+z=100
            int x = 1;//5元
            int y = 1;//1元
            int z = 1;//5角
            int sum = 0;
            Console.WriteLine("\t5元\t1元\t5角");
            Console.WriteLine("\t-------------------");
            for (x = 1; x <= 20; x++)
            {
                for (y = 1; y <= 100; y++)
                {
                    for (z = 1; z <= 200; z++)
                    {
                        if ((5 * x +  y + 0.5 * z) == 100 && (x + y + z) == 100)
                        {
                            Console.WriteLine("\tx={0}张\ty={1}张\tz={2}张", x, y, z);
                            sum++;
                        }
                    }
                }
            }
            Console.WriteLine("一种有{0}种方法", sum);//一种有1316种方法
            Console.ReadKey();
        }
    }
}

//        5元     1元     5角
//        -------------------
//        x=1张   y=91张  z=8张
//        x=2张   y=82张  z=16张
//        x=3张   y=73张  z=24张
//        x=4张   y=64张  z=32张
//        x=5张   y=55张  z=40张
//        x=6张   y=46张  z=48张
//        x=7张   y=37张  z=56张
//        x=8张   y=28张  z=64张
//        x=9张   y=19张  z=72张
//        x=10张  y=10张  z=80张
//        x=11张  y=1张   z=88张
//一种有11种方法
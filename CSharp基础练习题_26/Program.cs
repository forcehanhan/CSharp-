﻿/*
 * 时    间：2020年2月28日13:36:15
 * 题    目：26.编一个程序,输入二个正整数,求出它们的最大公约数。
 * 知 识 点：
 * 操作步骤：
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp基础练习题_26
{
    class Program
    {
        static void Main(string[] args) {
            //辗转相除法
            int c = 21;
            int d = 15;
            int v1, v2;
            while (c != 0 && d != 0)
            {
                v1 = c % d;
                v2 = d % v1;
                if (v1 % v2 == 0)
                {
                    Console.WriteLine("{0}和{1}的最大公约数是：{2}", c, d, v2);
                    break;
                }
            }

            //Console.ReadKey();


            //更相减损术
            int a = 9;
            int b = 15;
            int temp1 = a;
            int temp2 = b;
            while (a != b)
            {
                if (a > b)
                {
                    a -= b;

                }
                else
                {
                    b -= a;
                }
            }
            Console.WriteLine("{0}和{1}的最大公约数是：{2}", temp1, temp2, a);
            Console.ReadKey();
        }
    }
}

/*
 * 欧几里德算法又称辗转相除法，是指用于计算两个正整数a，b的最大公约数。应用领域有数学和计算机两个方面。计算公式gcd(a,b) = gcd(b,a mod b)。
欧几里德算法和扩展欧几里德算法可使用多种编程语言实现。
 欧几里德算法是用来求两个正整数最大公约数的算法。是由古希腊数学家欧几里德在其著作《The Elements》中最早描述了这种算法,所以被命名为欧几里德算法。
扩展欧几里德算法可用于RSA加密等领域。
假如需要求 1997 和 615 两个正整数的最大公约数,用欧几里德算法，是这样进行的：
1997 / 615 = 3 (余 152)
615 / 152 = 4(余7)
152 / 7 = 21(余5)
7 / 5 = 1 (余2)
5 / 2 = 2 (余1)
2 / 1 = 2 (余0)
至此，最大公约数为1
以除数和余数反复做除法运算，当余数为 0 时，取当前算式除数为最大公约数，所以就得出了 1997 和 615 的最大公约数 1。
     */

/*
 * 更相减损术
 * 使用步骤编辑
第一步：任意给定两个正整数；判断它们是否都是偶数。若是，则用2约简；若不是则执行第二步。
第二步：以较大的数减较小的数，接着把所得的差与较小的数比较，并以大数减小数。继续这个操作，直到所得的减数和差相等为止。
则第一步中约掉的若干个2的积与第二步中等数的乘积就是所求的最大公约数。
其中所说的“等数”，就是公约数。求“等数”的办法是“更相减损”法。
 例1、用更相减损术求98与63的最大公约数。
解：由于63不是偶数，把98和63以大数减小数，并辗转相减：
98-63=35
63-35=28
35-28=7
28-7=21
21-7=14
14-7=7
所以，98和63的最大公约数等于7。
 */

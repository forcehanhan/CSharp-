/*
 * 时    间：2020年2月29日00:07:45
 * 题    目：29.有关系式：1 * 1 + 2 * 2 + 3 * 3 +...+ k * k < 2000, 编一个程序,求出满足此关系式的k的最大值。
 * 知 识 点：
 * 操作步骤：
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp基础练习题_29
{
    class Program
    {
        static void Main(string[] args) {
            int k = 1;
            int s = 0;

            while (s < 2000)
            {
                s += k * k;
                k++;
            }
            Console.WriteLine(k);
            Console.ReadKey();
        }
    }
}

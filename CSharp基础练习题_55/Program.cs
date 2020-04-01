/*
 * 时    间：2020年3月1日23:07:40
 * 题    目：55.编一个程序，利用for语句，打印一个如下形式的一个等腰三角形，顶点在屏幕中线上，行数从键盘输入。
            　　　　＊
            　　　＊＊＊
            　　＊＊＊＊＊
            　＊＊＊＊＊＊＊
            ＊＊＊＊＊＊＊＊＊
 * 知 识 点：
 * 操作步骤：
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp基础练习题_55
{
    class Program
    {
        static void Main(string[] args) {
            Console.Write("请输入一个层数：");
            int n = int.Parse(Console.ReadLine());
            int m = 80;//假设屏幕宽度为80
            for (int i = 1; i <= n; i++)
            {
                //画空格
                //for (int j = 5 - i + 1; j >= 1; j--)
                for (int j = 1; j <= (m/2 - n/2) - n - i; j++)//要使*在屏幕的中心先上，就要计算最左边到中心线需要多少个=
                {
                    Console.Write("＝");
                }

                //画*
                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write("＊");
                }

                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
/*
请输入一个层数：10
＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＊
＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＊＊＊
＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＊＊＊＊＊
＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＊＊＊＊＊＊＊
＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＊＊＊＊＊＊＊＊＊
＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＊＊＊＊＊＊＊＊＊＊＊
＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＊＊＊＊＊＊＊＊＊＊＊＊＊
＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＊＊＊＊＊＊＊＊＊＊＊＊＊＊＊
＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＊＊＊＊＊＊＊＊＊＊＊＊＊＊＊＊＊
＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＊＊＊＊＊＊＊＊＊＊＊＊＊＊＊＊＊＊＊

*/

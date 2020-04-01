
/*
 * 时间：2020年2月25日18:09:06
 * 题目：//2.编一个程序，定义三个double类型的变量，分别从键盘上输入值给它们，
 * 然后用Console.WriteLine方法把它们输出成一列，小数点对齐，保留3位小数。
 * 实现目的：格式输出
 * 操作步骤：
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp基础练习题_02
{
    class Program
    {
        double v1 = 12.3487f;
        double v2 = 0.125631f;
        double v3 = 3.14159f;
        static void Main(string[] args) {
            Program p = new Program();
            Console.WriteLine("{0,6:F3}\n{1,6:F3}\n{2,6:F3}", p.v1, p.v2, p.v3);
            Console.ReadKey();
        }
    }
}
/*
    12.349
     0.126
     3.142
*/

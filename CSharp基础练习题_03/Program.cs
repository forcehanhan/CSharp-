/*
 * 时间：2020年2月26日00:20:09
 * 题目：4.编一个程序，从键盘上输入三个数，用三元运算符(?:)把最小数找出来。
 * 实现目的：
 * 操作步骤：
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp基础练习题_04
{
    class JudgeClass
    {
        public int JudegBug(string str, int order) {
            while (true)
            {
                try
                {
                    int number = int.Parse(str);
                    return number;
                }
                catch (Exception)
                {
                    Console.Write("不是数字，重新输入第{0}个数字：", order);
                    str = Console.ReadLine();
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args) {
            int[] num = new int[3];
            int order = 0;

            JudgeClass jc = new JudgeClass();
            order++;
            Console.Write("请输入第1个数字：");
            string str1 = Console.ReadLine();
            num[0] = jc.JudegBug(str1, order);

            order++;
            Console.Write("请输入第2个数字：");
            string str2 = Console.ReadLine();
            num[1] = jc.JudegBug(str2, order);

            order++;
            Console.Write("请输入第3个数字：");
            string str3 = Console.ReadLine();
            num[2] = jc.JudegBug(str3, order);

            order = 0;





            int min = 0;
            //min = (a < b ? a : b);
            //min = min < c ? min : c;
            //合并：
            //min = (a < b ? a : b) < c ? (a < b ? a : b) : c;

            //以上两步合并为一步：
            min = (num[0] < num[1] ? num[0] : num[1]) < num[2] ? (num[0] < num[1] ? num[0] : num[1]) : num[2];
            Console.WriteLine("最小值 Min = " + min);

            Console.ReadKey();
        }
    }
}

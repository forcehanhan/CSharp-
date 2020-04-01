/*
 * 时间：
 * 题目：1.编一个程序，定义常量Pi=3.14159265，从键盘上输入半径r求出圆的面积。
 * 实现目的：1、了解try-catch的用法。2、了解const的用法。
 * 操作步骤：
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp基础练习题_01
{
    class AreaClass
    {
        const float PI = 3.14159265f;
        public float GetArea(float r) {
            float area;
            area = PI * r * r;
            return area;
        }
    }
    class Program
    {
        static void Main(string[] args) {
            Console.Write("请输入圆的半径：r = ");
            string str = Console.ReadLine();
            float r;
            while (true)
            {
                try
                {

                    r = Convert.ToSingle(str);
                    AreaClass ac = new AreaClass();
                    float area = ac.GetArea(r);
                    Console.WriteLine("圆的面积 = " + area);
                    break;
                }
                catch
                {
                    Console.Write("只能输入数字，请重新输入：r = ");
                    str = Console.ReadLine();
                    //return;
                }


            }

            Console.ReadKey();
        }
    }
}

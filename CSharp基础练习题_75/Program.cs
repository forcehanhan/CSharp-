/*
 * 时    间：2020年3月7日16:47:17
 * 题    目：75.编一个程序，定义一个类，该类中定义二个非静态方法，一个方法用来求出这个三角形的周长，
 * 另一个方法用来求出这个三角形的面积。己知三角形三条边a,b,c,计算其面积可以用Math类中的Sqrt()方法，
 * 有表达式Math.Sqrt(s*(s-a)*(s-b)*(s-c)),可以利用它计算指定数的开方，其中s=(a+b+c)/2。
 * 在主方法中输入一个三角形三条边a,b,c,要求调用这二个非静态方法计算三角形的周长和面积。
 * 注意:在输入三角形三条边时，必须检查它们的数据合法性。
 * 知 识 点：
 * 操作步骤：
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp基础练习题_75
{
    class Triangle
    {
        //求三角形的周长
        public float GetTriPerimeter(float a, float b, float c) {
            //判断三角形三条边长的合法性：a+b>c && a+c>b && b+c>a
            if (a + b > c && a + c > b && b + c > a)
            {
                float perimeter = a + b + c;
                return perimeter;
            }
            else
            {
                return -1;
            }

        }

        //求三角形的面积
        public float GetTriArea(float a, float b, float c) {
            //判断三角形三条边长的合法性：a+b>c && a+c>b && b+c>a
            if (a + b > c && a + c > b && b + c > a)
            {
                float p = (a + b + c) / 2;
                float area = (float)Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                return area;
            }
            else
            {
                return -2;
            }
        }
    }

    class Program
    {
        static void Main(string[] args) {
            Console.Write("请输入三角形的第一个边长：");
            float a = Convert.ToSingle(Console.ReadLine());

            Console.Write("请输入三角形的第二个边长：");
            float b = Convert.ToSingle(Console.ReadLine());

            Console.Write("请输入三角形的第三个边长：");
            float c = Convert.ToSingle(Console.ReadLine());

            Triangle t = new Triangle();
            float perimeter = t.GetTriPerimeter(a, b, c);
            float area = t.GetTriArea(a, b, c);

            Console.WriteLine("三角形的周长={0}，面积={1}", perimeter, area);
            Console.ReadKey();
        }
    }
}
/*
请输入三角形的第一个边长：3
请输入三角形的第二个边长：4
请输入三角形的第三个边长：5
三角形的周长=12，面积=6
*/
/*
请输入三角形的第一个边长：5
请输入三角形的第二个边长：12
请输入三角形的第三个边长：13
三角形的周长=30，面积=30
*/

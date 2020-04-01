/*
 * 时    间：2020年3月8日22:33:45
 * 题    目：80.控制台应用程序，定义描述复数的类Complex，具体要求如下:
 *              通过重载运算符: +、-、*、/，直接实现两个复数之间的各种运算。
 *              其中，
 *              两个复数相乘的计算公式为(a+bi)*(c+di)=(ac-bd)+(ad+bc)i 。
 *              两个复数相除的计算公式为(a+bi/(c+di)=(ac+bd)/(c*c+d* d)+(bc-ad)/(c*c+d*d)。
 *              定义主函数测试类，在主函数中定义两个复数2+3i和1+2i，实现两个复数的加减，并将结果输出。
 * 知 识 点：
 * 操作步骤：
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp基础练习题_80
{
    class Complex
    {
        //虚数（复数）i：已知i*i = -1;
        //z1 = a + b*i;//虚数z1
        //z2 = c + d*i;//虚数z2
        //z1 + z2 = (a + b*i) + (c + d*i) = (a + c) + (b + d)*i;
        //z1 + z2 = (a + b*i) - (c + d*i) = (a - c) + (b - d)*i;
        //z1 * z2 = (a + b*i) * (c + d*i) = (a*c - b*d) + (a*d + b*c)*i;
        //z1 / z2 = (a + b*i) / (c + d*i) = (a*c + b*d) / (c*c + d*d) + ((b*c - a*d) / (c*c + d*d))*i;

        //a + b*i
        private double a;//虚数的实部
        private double b;//虚数的虚部
        private double x;
        private double y;

        public static int flag;

        //传参：初始化a,b
        public Complex(double a, double b) {

            this.a = a;
            this.b = b;
            x = a;
            y = b;
        }

        //+重载
        public static Complex operator +(Complex z1, Complex z2) {
            flag = 1;
            //z3 = z1 + z2;
            //z3.a = z1.a + z2.a;
            //z3.b = z1.b + z2.b;
            //z3 =  (z1.a + z2.a) + (z1.b + z2.b)*i;
            Complex z3 = new Complex((z1.a + z2.a), (z1.b + z2.b));
            return z3;
        }

        //-重载
        public static Complex operator -(Complex z1, Complex z2) {
            flag = 2;
            Complex z3 = new Complex((z1.a - z2.a), (z1.b - z2.b));
            return z3;
        }

        //*重载
        //z1 * z2 = (a + b*i) * (c + d*i) = (a*c - b*d) + (a*d + b*c)*i;
        public static Complex operator *(Complex z1, Complex z2) {
            flag = 3;
            Complex z3 = new Complex((z1.a * z2.a - z1.b * z2.b), (z2.a * z2.b + z1.b * z2.a));
            return z3;
        }

        //÷重载
        public static Complex operator /(Complex z1, Complex z2) {
            flag = 4;
            Complex z3 = new Complex((z1.a * z2.a + z1.b * z2.b) / (z2.a * z2.a + z2.b * z2.b), (z1.b * z2.a - z1.a * z2.b) / (z2.a + z2.b));
            return z3;

        }
        public override string ToString() {
            //return a + "+" + b + "*i";
            //return string.Format("({0:F}) + ({1:F})*i", a, b);
            switch (flag)
            {
                case 1:
                    return string.Format("z1 + z2：({0:F}) + ({1:F})*i", a, b);
                    //break;
                case 2:
                    return string.Format("z1 - z2：({0:F}) + ({1:F})*i", a, b);
                    //break;
                case 3:
                    return string.Format("z1 * z2：({0:F}) + ({1:F})*i", a, b);
                    //break;
                case 4:
                    return string.Format("z1 / z2：({0:F}) + ({1:F})*i", a, b);
                    //break;
                default:
                    return string.Format("({0:F}) + ({1:F})*i", a, b);
                    //break;
            }

        }
    }
    class Program
    {
        static void Main(string[] args) {
            //2 + 3i和1 + 2i
            double a1 = 2;
            double b1 = 3;
            double a2 = 1;
            double b2 = 2;


            Complex z1 = new Complex(a1, b1);
            Complex z2 = new Complex(a2, b2);
            Console.WriteLine(z1 + z2);
            Console.WriteLine(z1 - z2);
            Console.WriteLine(z1 * z2);
            Console.WriteLine(z1 / z2);
            Console.ReadKey();
        }
    }
}
/*
(3.00) + (5.00)* i
(1.00) + (1.00)* i
(-4.00) + (5.00)* i
(1.60) + (-0.33)* i
*/

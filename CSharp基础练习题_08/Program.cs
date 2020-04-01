/*
 * 时    间：2020年2月26日16:23:57
 * 题    目：8.编一个程序，设园半径r=1.5，园柱高h=3.6，圆周率3.1415定义为常量，求出圆周长、圆面积、圆柱体积。
 *          然后用 Console. WriteLine方法输出计算结果，输出时要求有文字说明，取小数点后2位数字。例如，圆周长=×××.×。
 * 实现目的：
 * 操作步骤：
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp基础练习题_08
{
    class Program
    {
        static void Main(string[] args) {
            float r = 1.2f;
            float h = 1.5f;
            CylinderClass cc = new CylinderClass();
            float res = cc.GetVCylinder(r, h);
            Console.WriteLine("圆的底面半径是1.2，圆柱的高是1.5， ");
            Console.WriteLine("圆的体积是 = " + res);
            Console.ReadKey();
        }
    }

    class CylinderClass
    {
        public float GetVCylinder(float r, float h) {
            r = 1.2f;
            h = 1.5f;
            const float Pi = 3.1415f;
            float vCylinder = Pi * r * r * h;
            return vCylinder;
        }
    }
}

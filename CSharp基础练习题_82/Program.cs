/*
 * 时    间：
 * 题    目：82.把定义平面直角坐标系上的一个点的类CPoint作为基类，派生出描述一条直线的类Cline，再派生出一个矩形类CRect。
 * 要求成员函数能求出给定的两点(a,b)、(20,30) 间的距离、矩形的周长和面积。编写完整的控制台程序。
 * 要求:
 * (1)类CPoint中定义两个私有变量x,y。int类型及能够访问到它们的公有属性;
 * (2)类CPoint中定义带有两个参数的构造函数，及能够输出两个点的方法Display();
 * (3)类Cline派生自类CPoint，也有自己的构造函数，及输出直线距离的方法Distance();
 * (4)矩形类CRect派生 自类Cline，有自己的构造函数，计算矩形的周长方法是Perim()，面积是Area()。
 * 知 识 点：
 * 操作步骤：
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp基础练习题_82
{
    /// <summary>点坐标信息 </summary>
    public class CPoint//基类
    {
        private int x;
        private int y;
        public int X { get { return x; } set { x = value; } }
        public int Y { get { return y; } set { y = value; } }
        //public int GetX() { return x; }
        //public int GetY() { return y; }
        public CPoint() { }
        public CPoint(int x, int y) {
            this.x = x;
            this.y = y;
        }
        public void Dispaly() {

            ////Console.Write("({0},{1})", X, Y);
            Console.Write("({0},{1})", x, y);
            //return "( " + x.ToString() + "," + y.ToString() + ")";
        }
    }//CPoint

    /****************************************************************/
    /// <summary>直线距离</summary>
    public class CLine : CPoint//派生类
    {
        CPoint p1, p2;
        public CLine() { }
        public CLine(CPoint p1, CPoint p2) {
            this.p1 = p1;
            this.p2 = p2;
        }
        public float Distance() {
            //float distance = (float)Math.Sqrt((p1.GetX() - p2.GetX()) * (p1.GetX() - p2.GetX()) + (p1.GetY() - p2.GetY()) * (p1.GetY() - p2.GetY()));
            float distance = (float)Math.Sqrt((p1.X - p2.X) * (p1.X - p2.X) + (p1.Y - p2.Y) * (p1.Y - p2.Y));
            return distance;
        }
    }

    /***********************************************************************/
    /// <summary>求矩形的周长、面积</summary>
    public class CRect : CLine//派生类
    {
        CLine l1, l2;
        public CRect(CLine l1, CLine l2) {
            this.l1 = l1;
            this.l2 = l2;
        }
        //求周长
        public float Perimeter() {
            float perimeter = 2 * (l1.Distance() + l2.Distance());
            return perimeter;
        }
        //求面积
        public float Area() {
            float area = l1.Distance() * l2.Distance();
            return area;
        }
    }

    class Program
    {
        static void Main(string[] args) {

            //输入A点坐标
            Console.Write("点A");
            int x1 = 1;
            int y1 = 1;
            CPoint p1 = new CPoint(x1, y1);
            p1.Dispaly();//打印出点

            Console.Write("到");

            //输入B点坐标
            Console.Write("点B");
            int x2 = 6;
            int y2 = 6;
            CPoint p2 = new CPoint(x2, y2);
            p2.Dispaly();//打印出点
            Console.Write("的距离：");

            //两点的距离
            CLine l = new CLine(p1,p2);
            float dis = l.Distance();
            Console.WriteLine("{0:F3}。",dis);//:F3指保留三位小数。

            //矩形的周长
            int x3 = 8, y3 = 8;
            int x4 = 10, y4 = 10;
            CPoint p3 = new CPoint(x3, y3);
            CPoint p4 = new CPoint(x4, y4);

            CLine l1 = new CLine(p1,p2);
            CLine l2 = new CLine(p3,p4);

            CRect peri = new CRect(l1, l2);
            float perimeter = peri.Perimeter();
            Console.WriteLine("矩形的周长:{0}", perimeter);

            //矩形的面积
            float area = peri.Area();
            Console.WriteLine("矩形的面积:{0}", area);
            Console.ReadKey();
        }
    }
}

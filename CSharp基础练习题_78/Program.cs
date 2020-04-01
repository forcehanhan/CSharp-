/*
 * 时    间：2020年3月8日01:24:25
 * 题    目：78.编写一个矩形类，私有数据成员为举行的长(len) 和宽(wid)，
 * 无参构造函数将len和wid设置为0，有参构造函数设置属性的值，另外，类还包括矩形的周长、面积。
 * 取矩形的长度、取矩形的宽度、修改矩形的长度和宽度为对应的形参值等公用方法。
 * 知 识 点：
 * 操作步骤：
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp基础练习题_78
{
    class Rectangle
    {
        private float lenth;//长
        private float width;//宽
        private float area;//面积
        private float perimeter;//周长
        public float Lenth { get => lenth; set => lenth = value; }
        public float Width { get => width; set => width = value; }
        public float Perimeter { get => perimeter = 2 *( Lenth +  Width);}
        public float Area { get => area = Lenth * width; }

        public Rectangle() {
            Lenth = 0.0f;
            Width = 0.0f;
        }
        public Rectangle(float lenth,float width) {
            this.Lenth = lenth;
            this.Width = width;           
        }

        //public float GetArea(float lenth, float width) {
        //    Area = Lenth * width;
        //    return Area;
        //}

        public override string ToString() {
            return "矩形周长=" + Perimeter + "," + "矩形面积=" + Area;
        }
    }
    class Program
    {
        static void Main(string[] args) {
            float lenth = 0.0f;
            float width = 0.0f;
            Console.Write("请输入矩形的长度：");
            lenth = Convert.ToSingle(Console.ReadLine());

            Console.Write("请输入矩形的宽度：");
            width = Convert.ToSingle(Console.ReadLine());

            Rectangle rec = new Rectangle(lenth, width);
            Console.WriteLine(rec);
            Console.ReadKey();
        }
    }
}
/*请输入矩形的长度：6.0
请输入矩形的宽度：4.0
矩形周长=20,矩形面积=24*/
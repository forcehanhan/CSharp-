/*
 * 时    间：2020年3月6日20:09:41
 * 题    目：70.编一个程序，输入三个double类型数据，自定义一个静态方法，把这三个数送给它，返回找出的最大数。
 * 知 识 点：
 * 操作步骤：
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp基础练习题_70
{
    class MyClass
    {
       public  static double GetMax(double d1,double d2,double d3) {
            double max;
            double temp;
            //方法一：
            temp = d1 > d2 ? d1 : d2;
            max = temp > d3 ? temp : d3;
            //max = (d1 > d2 ? d1 : d2) > d3 ? (d1 > d2 ? d1 : d2) : d3;
            return max;

            //方法二：
            //if (d1 < d2)
            //{
            //    max = d2;
            //}else 
            //{
            //    max = d1;
            //}

            //if (max <d3)
            //{
            //    max = d3;
            //}
            //else
            //{
            //    return max;
            //}
            //return max;
        }
    }
    class Program
    {
        static void Main(string[] args) {

           double res = MyClass.GetMax(1201.2145f, 10.1125f, 450.1215f);
            Console.WriteLine("最大值为："+res);
            
            Console.ReadKey();
        }
    }
}

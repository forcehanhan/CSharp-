/*
 * 时    间：2020年3月8日23:26:06
 * 题    目：81.定义Maxer类，具体要求如下:
 *          类中声明的方法Max()要有三种重载形式在Main方法中调用时，
 *          会根据实参的数据类型(int、 double、 string) 来自动调用相应的方法求各种类型中的最大数。
 *          (比如:输入13、45、-78、 70时，就输出最大数为45;输入3.4、78.2、 12.6时，就能输出最大数为78.2;
 *          输入”love”、”beiling" 时，就能输出最长的字符串”beiing")
 * 知 识 点：
 * 操作步骤：
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp基础练习题_81
{
    class MaxClass
    {
        public int GetMax(int a,int b,int c,int d) {
            int max = 0;
            max = a > b ? a : b;
            max = max > c ? max : c;
            max = max > d ? max : d;
            return max;
        }

        public double GetMax(double a, double b, double c,double d) {
            double max = 0;
            max = a > b ? a : b;
            max = max > c ? max : c;
            max = max > d ? max : d;
            return max;
        }

        public string GetMax(string a, string b, string c,string d) {
            int i = 0;
            string strMax = "";
            string[] strArr = new string[] { a, b, c, d };
            for (i = 0; i < strArr.Length; i++)
            {
                if (strMax.Length < strArr[i].Length)
                {
                    strMax = strArr[i];
                }
            }
            return strMax;
            
        }
    }
    class Program
    {
        static void Main(string[] args) {
            MaxClass mc = new MaxClass();
            Console.WriteLine("Max = {0}", mc.GetMax(2, 8, 4,10));
            Console.WriteLine("Max = {0}", mc.GetMax(20.10f, 8.12f, 40.22f,10.52f));
            Console.WriteLine("Max = {0}", mc.GetMax("shanghai","beijing","shenzhen","guangzhou"));

            Console.ReadKey();
        }
    }
}
/*
Max = 10
Max = 40.2200012207031
Max = guangzhou
*/


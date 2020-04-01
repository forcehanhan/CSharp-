/*
 * 时    间：2020年2月27日13:46:54
 * 题    目：17.编一个程序,首先输入一个成绩(0到100的整数),用if else语句然后判断成绩是优、良、中、及格还是不及格。
 * 知 识 点：
 * 操作步骤：
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp基础练习题_17
{
    class Program
    {
        static void Main(string[] args) {
            MyClass mc = new MyClass();
            Console.Write("请输入一个成绩（1-100之间）：");
            int score = int.Parse(Console.ReadLine());
            mc.GetScore(score);
            Console.ReadKey();
        }
    }

    class MyClass
    {
        public void GetScore(int score) {

            if (score >= 60 && score < 70)
            {
                Console.WriteLine("及格");
            }
            else if (score >= 70 && score < 80)
            {
                Console.WriteLine("中");
            }
            else if (score >= 80 && score < 90)
            {
                Console.WriteLine("良");
            }
            else if (score >= 90 && score < 100)
            {
                Console.WriteLine("优");
            }
            else
            {
                Console.WriteLine("不及格");
            }
        }
    }
}
/*
 * 时    间：2020年3月9日23:45:07
 * 题    目：83.定义一个描述学生基本情况的类StuInfo。具体要求如下:
(1)类中包括私有的数据成员字段:姓名name, 学号num,类型为String;课程cop, 课程english,课程math, 类型为int。
(2)定义对字段的公有访问属性。
(3)定义构造函数对类中的字段进行初始化。
(4)定义公有方法求总成绩和平均成绩,方法原型如下:
public int SumOfScore();
public int AverageOfScore();
(5)定义测试类，在测试类的主函数中，声明一个stulnfo的对象(张三”，”1001",68,78,80)，调用相应的方法，输出其总分和平均分。
 * 知 识 点：
 * 操作步骤：
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp基础练习题_83
{
    class StuInfo
    {
        //字段
        private string name;//姓名
        private string num;//学号
        private int cop;//课程
        private int english;//课程
        private int math;//课程

        //属性
        public string Name { get => name; set => name = value; }
        public string Num { get => num; set => num = value; }
        public int Cop { get => cop; set => cop = value; }
        public int English { get => english; set => english = value; }
        public int Math { get => math; set => math = value; }

        //初始化
        public StuInfo(string name, string num, int cop, int english, int math) {
            this.name = name;
            this.num = num;
            this.cop = cop;
            this.english = english;
            this.math = math;
        }

        //求总成绩
        public int SumOfScore() {
            int sum = Cop + English + Math;
            return sum;
        
        }

        //求平均成绩
        public int AverageOfScore() {
            int average = (Cop + English + Math) / 3;
            return average;
        }
        public override string ToString() {
            return string.Format("总成绩是：{0} ，平均成绩是：{1}", SumOfScore(), AverageOfScore());
        }
    }
    class Program
    {
        static void Main(string[] args) {

            StuInfo stu1 = new StuInfo("张三", "1001", 68, 78, 80);
            StuInfo stu2 = new StuInfo("李四", "1002", 60, 68, 99);
            Console.WriteLine(stu1) ;
            Console.WriteLine(stu2) ;
            Console.ReadKey();
        }
    }
}
/*总成绩是：226 ，平均成绩是：75
总成绩是：227 ，平均成绩是：75*/


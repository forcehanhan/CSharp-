/*
 * 时    间：
 * 题    目：10.编一个程序，定义结构类型(有学号、姓名、性别、程序设计成绩四个字段)，声明该结构类型变量，用赋值语句对该变量赋值以后再输出。
 * 实现目的：
 * 操作步骤：
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp基础练习题_10
{
    public struct StudenStruct
    {
        public int studentId;//学号
        public string studentName;//姓名
        public string studenSex;//性别
        public int studetScore;//成绩

        //初始化
        public StudenStruct(int studentId, string studentName, string studenSex, int studetScore) {
            this.studentId = studentId;
            this.studentName = studentName;
            this.studenSex = studenSex;
            this.studetScore = studetScore;
        }
        public override string ToString() {
            return "学号：" + studentId + " | 姓名：" + studentName + " | 性别：" + studenSex + " | 成绩：" + studetScore;
        }
    }
    class Program
    {
        static void Main(string[] args) {
            //实例化，并赋值
            StudenStruct ss = new StudenStruct(13, "Hank", "Male", 99);
            Console.WriteLine(ss.ToString());
            Console.ReadKey();
        }
    }
}
/*
 学号：13 | 姓名：Hank | 性别：Male | 成绩：99
     */

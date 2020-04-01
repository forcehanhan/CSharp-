/*
 * 时    间：2020年3月6日14:51:23
 * 题    目：67.编一个程序，定义类student和它的成员( 学号,姓名，年龄和c_ sharp程序设计成绩),
 * 用类student生成对象s,分别对对象s的成员赋值，然后输出对象s。
 * 知 识 点：
 * 操作步骤：
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp基础练习题_67
{
    class Student
    {
        int id;
        string name;
        byte age;
        int score;
        
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public byte Age
        {
            get { return age; }
            set { age = value; }
        }

        public int Score
        {
            get { return score; }
            set { score = value; }
        }
        //初始化信息

        public Student(int id,string name,byte age,int score) {
            this.id = id;
            this.name = name;
            this.age = age;
            this.score = score;
        }

        //输出信息
        public override string ToString() {
            return "学号:" + id + "   姓名:" + name + "   年龄:" + age + "    成绩:" + score;

        }
    }
    class Program
    {
        static void Main(string[] args) {
            Student s = new Student(13,"Hank",255,99000000);
            Console.WriteLine(s);
            s.Id = 25;
            s.Name = "李四";
            s.Age = 15;
            s.Score = 100;
            Console.WriteLine(s);

            Student b = new Student(12, "张三", 20, 10);
            

            Console.WriteLine(b);
            Console.ReadKey();
        }
    }
}

//学号:13   姓名:Hank 年龄:255    成绩:99000000
//学号:25   姓名:李四 年龄:15    成绩:100
//学号:12   姓名:张三 年龄:20    成绩:10


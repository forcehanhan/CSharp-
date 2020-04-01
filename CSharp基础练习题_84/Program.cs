/*
 * 时    间：2020年3月10日00:29:20
 * 题    目：84.定义一个Person类，并由Person类派生出类Student。
 * ■Person类的具体要求如下:
 *  (1)包括私有数据成员: 姓名name,编号number,性别sex，均为string类型
 *  (2)定义私有数据成员的公有访问属性
 *  (3)定义Person的构造函数，用于对三个数据成员赋值。
 * ■Student类的具体要求:
 *  (1)增加私有数据成员:成绩score, int类型
 *  (2)定义私有数据成员score的公有访问属性
 *  (3)定义Student的构造函数，可以对本类中及父类的成员进行初始化。
 *  (4)定义输出函数，可以输出学生的详细信息。原型如下:
 *      public void print();
 *  (5)在主函数中定义一个学生zs， 姓名为:张三，编号为: 1001， 性别为:男，成绩为: 80。
 *      调用Student类中的print方法输出张三的所有信息。
 * 知 识 点：
 * 操作步骤：
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp基础练习题_84
{
    class Person
    {
        private string name;//姓名
        private string number;//学号
        private string sex;//性别

        public string Name { get => name; set => name = value; }
        public string Number { get => number; set => number = value; }
        public string Sex { get => sex; set => sex = value; }

        //public Person() {

        //}
        public Person(string name,string number,string sex) {
            this.name = name;
            this.number = number;
            this.sex = sex;
        }
    }
    class Student: Person
    {
        private int score;//成绩
        public int Score { get => score; set => score = value; }

        //public Student() {
        //    Student s = new Student();
        //}
        public Student(string name,string number,string sex,int score):base(name ,number ,sex) {
            this.score = score;
        }
        
        public void Print() {
            Console.WriteLine("姓名：{0}，学号：{1}，性别：{2}，成绩：{3}",Name,Number ,Sex,Score);
        }
    }
    class Program
    {
        static void Main(string[] args) {
            Student zs = new Student("张三", "1001", "男", 99);
            zs.Print();
            Student ls = new Student("李四", "1002", "女", 66);
            ls.Print();
            Console.ReadKey();
        }
    }
}
/*
姓名：张三，学号：1001，性别：男，成绩：99
姓名：李四，学号：1002，性别：女，成绩：66
*/
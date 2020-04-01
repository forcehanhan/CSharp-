/*
 * 时    间：2020年3月6日15:47:55
 * 题    目：68.编一个程序，定义结构(有姓名，年龄，手机号码三个字段)，
 * 再定义一个一维数组，把结构作为数组元素类型，存入数据，然后依次输出。
 * 知 识 点：
 * 操作步骤：
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp基础练习题_68
{
    public struct PersonInfo
    {
        public string name;
        public byte age;
        public long telephone;
        public override string ToString() {
            return "姓名:" + name + "   年龄:" + age + "    电话:" + telephone;
        }
    }
    class Program
    {
        static void Main(string[] args) {
            PersonInfo p = new PersonInfo();
            int n = 3;
            PersonInfo[] pArray = new PersonInfo[n];

            //p.name = "张三";
            //p.age = 30;
            //p.telephone = 18899998888;

            pArray[0].name = "张三";
            pArray[0].age = 22;
            pArray[0].telephone = 13333333333;

            pArray[1].name = "李四";
            pArray[1].age = 33;
            pArray[1].telephone = 14444444444;

            pArray[2].name = "张五";
            pArray[2].age = 44;
            pArray[2].telephone = 15555555555;

            //Console.WriteLine(pArray[0]);
            //Console.WriteLine(pArray[1]);
            //Console.WriteLine(pArray[2]);
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(pArray[i]);
            }

            Console.ReadKey();
        }
    }
}
//姓名:张三 年龄:22    电话:13333333333
//姓名:李四 年龄:33    电话:14444444444
//姓名:张五 年龄:44    电话:15555555555

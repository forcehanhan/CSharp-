/*
 * 时    间：
 * 题    目：69.编一个程序，定义类(有姓名，年龄，手机号码三个字段)，
 * 再定义一个一维数组，使数组元素为类，存入数据，然后依次输出,
 * 使用for循环语句进行输入输出操作。
 * 知 识 点：每输入一个数据之前，都要事先实例化一个对象来接收该数据。
 * 操作步骤：
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp基础练习题_69
{
    public class PersonInfo
    {
        string name;
        byte age;
        string telephone;

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
        public string Telephone
        {
            get { return telephone; }
            set { telephone = value; }
        }

        public PersonInfo(string name, byte age, string telephone) {
            this.name = name;
            this.age = age;
            this.telephone = telephone;

        }
        public override string ToString() {
            return "姓名:" + Name + "   年龄:" + Age + "    电话:" + Telephone;
        }

    }
    class Program
    {
        static void Main(string[] args) {
            //PersonInfo p;
            int n = 3;
            int i = 0, j = 0;
            PersonInfo[] pArray = new PersonInfo[n];

            for (i = 0; i < n; i++)
            {
                //先要实例化对象，这样才能使 pArray[j]接收数据。
                pArray[i] = new PersonInfo("姓名", 0, "电话");
            }
            for (j = 0; j < pArray.Length; j++)
            {
                Console.Write("请输入姓名：");
                pArray[j].Name = Console.ReadLine();

                Console.Write("请输入年龄：");
                pArray[j].Age = byte.Parse(Console.ReadLine());

                Console.Write("请输入电话：");
                pArray[j].Telephone = Console.ReadLine();
            }

            Console.WriteLine("----------------以下输出-----------------");
            for (i = 0; i < n; i++)
            {
                Console.WriteLine(pArray[i]);
            }

            Console.ReadKey();
        }
    }
}
/*
请输入姓名：张三
请输入年龄：11
请输入电话：13100000000
请输入姓名：李四
请输入年龄：22
请输入电话：13200000000
请输入姓名：张五
请输入年龄：33
请输入电话：13300000000
----------------以下输出-----------------
姓名:张三 年龄:11    电话:13100000000
姓名:李四 年龄:22    电话:13200000000
姓名:张五 年龄:33    电话:13300000000
*/
/*
 * 时    间：2020年2月28日23:11:00
 * 题    目：28.编一个程序,要求使用while语句,输入用户名和密码,实现用户登录程序的功能,至多允许输入三次,超过三次不允许登录。
 * 知 识 点：
 * 操作步骤：
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp基础练习题_28
{
    class Program
    {
        static void Main(string[] args) {
            
            if (true)
            {
                MyClass mc = new MyClass();
                mc.Judge();
            }
            Console.ReadKey();
        }

        class MyClass
        {
            public void Judge() {
                const string UserName = "admin";
                const string PassWord = "mima2020";
                string userName;
                string passWord;
                int i = 1;
                while (i <= 3)
                {
                    Console.WriteLine("请输入你的用户名");
                    Console.Write("用户名：");
                    userName = Console.ReadLine();

                    Console.WriteLine("请输入你的密码");
                    Console.Write("密  码：");
                    passWord = Console.ReadLine();
                    //int val = str.CompareTo(PassWord);
                    if (userName == UserName && passWord == PassWord)
                    {
                        Console.WriteLine("正在登陆系统...");
                        break;
                    }
                    else
                    {
                        //Console.Write("密码错误！");
                        switch (i)
                        {
                            case 1:
                                Console.WriteLine("密码错误！还可以输入2次！");
                                break;
                            case 2:
                                Console.WriteLine("密码错误！还可以输入1次！");
                                break;
                            case 3:
                                Console.WriteLine("账号被锁定！");
                                break;
                            default:
                                Console.WriteLine("请按规定输入正确的密码");
                                break;
                        }
                        i++;
                    }
                }
            }
        }
    }
}

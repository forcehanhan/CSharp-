/*
 * 时    间：
 * 
 * 题    目：79.编写一个控制台应用程序，接收一个长度大于3的字符串，完成下列功能:
 *          1)输出字符串长度。
 *          2)输出字符串中第一个出现字母a的位置。
 *          3)在字符串的第4个字符后面插入字符串“hello", 输出新字符串。
 *          4)将字符串“hello”替换成“me”， 输出新字符串。
 *          5)以字符“m”为分隔符，将字符串分离，并输出分离后的字符串。
 * 
 * 知 识 点：1、获取字符串和长度。2、字符串的拷贝、3、字符的分离
 * 
 * 操作步骤：
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp基础练习题_79
{
    class Program
    {
        static void Main(string[] args) {
            int i = 0;
            string str1 = "www.abc.com";
            string str2 = "hello";
            string str3 = "me";

            //获取字符串的长度
            Console.WriteLine("字符串“{0}”的长度 = {1}。",str1,str1.Length);

            //方法一：判断第一个字母a出现的位置
            //foreach (char c in str1)
            //{
            //    i++;
                
            //    if (c=='a')
            //    {
            //        Console.WriteLine("字母a出现在第{0}个位置。",i);
            //        break;
            //    }
            //}

            //方法二：判断第一个字母a出现的位置
            int index = str1.IndexOf("a");
            Console.WriteLine("字母a出现在第{0}个位置。",index+1);

            //在第4个字符后面插入"hello"
            str1 = str1.Insert(4, str2);
            Console.WriteLine("新的字符串是：{0}" ,str1);

            //替换字符
            str1 = str1.Replace("hello", str3);
            Console.WriteLine("替换后，新的字符串是：{0}", str1);
            Console.ReadKey();
        }
    }
}
/*
字符串“www.abc.com”的长度 = 11。
字母a出现在第5个位置。
新的字符串是：www.helloabc.com
替换后，新的字符串是：www.meabc.com
*/

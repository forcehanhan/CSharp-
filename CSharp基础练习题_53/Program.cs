/*
 * 时    间：2020年3月1日22:45:31
 * 题    目：53.编一个程序，定义一个字符串变量，输入字符串，判断有没有"连续"重复字符出现，统计重复字符出现次数。
 *              例如， aaabccdfff ,其中a重复出现二次, c重复出现一次, f重复出现二次,共计字符重复五次。
 * 知 识 点：
 * 操作步骤：
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp基础练习题_53
{
    class Program
    {
        static void Main(string[] args) {
            string str = "aaaqqbccaadfff";
            char[] ch = str.ToCharArray();
            int sum = 0;
            for (int i = 1; i <= ch.Length-1; i++)
            {
                if (ch[i - 1] == ch[i])
                {

                    sum++;
                }
            }
            Console.WriteLine("共计重复{0}次",sum);
            Console.ReadKey();
        }
    }
}
//共计重复7次
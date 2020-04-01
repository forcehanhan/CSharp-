/*
 * 时    间：2020年3月3日13:39:32
 * 题    目：59.编一个程序，输入一个代表身份证号码的字符串，判断字符串长度(18)是否正确，
 *          还要判断入的每个字符是否为数字，否则要求重输入。
 * 知 识 点：
 * 操作步骤：
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp基础练习题_59
{
    class Program
    {
        static void Main(string[] args) {
            int id;//身份证号码
            Console.WriteLine("请输入身份证号：");
            string strId = Console.ReadLine();
            int strLenth = strId.Length;
            bool isNumber = false;
            foreach (char c in strId)
            {
                if (c >= '0' && c <= '9')
                {
                    isNumber = true;
                }
                else
                {
                    isNumber = false;
                    break;
                }
            }


            if (strLenth == 18 && isNumber == true)
            {

                Console.WriteLine("身份证正确。");
            }
            else
            {
                Console.WriteLine("身份证不符合要求，请重新输入。");
            }
            Console.ReadKey();
        }
    }
}
/*
请输入身份证号：
351227201112121
身份证正确。
   
请输入身份证号：
35122720111212x
身份证不符合要求，请重新输入。
*/

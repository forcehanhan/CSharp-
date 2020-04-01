/*
 * 时    间：2020年3月6日14:48:23
 * 题    目：66.编一个程序，定义一个字符串数组，输入若干国家名称(所有名称全用大写或者全用小写)，
 *              设计一个算法按字典顺序将这些国家名称进行排序。
 * 知 识 点：1、冒泡排序 2、string.Compare(strA,strB)
 * 操作步骤：
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp基础练习题_66
{
    class Program
    {
        static void Main(string[] args) {

            int n = 10;//数组的长度
            string temp;//临时变量
            //string[] strName = { "China", "American", "Japan", "French" };
            //输入国家的名字
            Console.WriteLine("请输入国家的名称：");
            string[] strName =new string[n];
            for (int i = 0; i < n; i++)
            {
                strName[i] = Console.ReadLine();
            }

            Console.WriteLine("\n排序后的名称：");
            //冒泡排序
            for (int i = 0; i < strName.Length; i++)
            {
                for (int j = 1; j < strName.Length - i; j++)
                {
                    if (string.Compare(strName[j-1], strName[j]) > 0)
                    {
                        temp = strName[j - 1];
                        strName[j - 1] = strName[j];
                        strName[j] = temp;
                    }
                }
            }

            for (int i = 0; i < strName.Length; i++)
            {
                Console.WriteLine("{0} ", strName[i]);
            }

            Console.ReadKey();
        }
    }
}

//请输入国家的名称：
//Afghanistan
//Japan
//Danemark
//Finnland
//Frankreich
//Griechenland
//England
//China
//Irland
//American

//排序后的名称：
//Afghanistan
//American
//China
//Danemark
//England
//Finnland
//Frankreich
//Griechenland
//Irland
//Japan

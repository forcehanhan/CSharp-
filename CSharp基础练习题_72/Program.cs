/*
 * 时    间：2020年3月6日22:21:47
 * 题    目：72.编一个程序，从键盘上输入三个int类型的数，自定义方法，
 * 以从小到大的顺序排序,以引用型参数调用方法，然后返回主方法输出结果。
 * 知 识 点：
 * 操作步骤：
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp基础练习题_72
{
    class MyClass
    {
        public void SortNumber(ref int a, ref int b, ref int c) {
            int temp;
            //1、确定a和b之间的大小关系
            if (a > b) { temp = a; a = b; b = temp; }

            //2、确定b和c之间的大小关系
            if (b > c) { temp = b; b = c; c = temp; }

            //3、确定a和b之间的大小关系：由上面两步已经确定了c的大小，则可以排除c不用比较了，则只需要比较a、b之间的大小了。
            if (a > b) { temp = a; a = b; b = temp; }
        }
    }
    class Program
    {
        static void Main(string[] args) {
            Console.Write("请输入第一个数：");
            int a = int.Parse(Console.ReadLine());

            Console.Write("请输入第二个数：");
            int b = int.Parse(Console.ReadLine());

            Console.Write("请输入第三个数：");
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine("排序后：");
            MyClass mc = new MyClass();

            mc.SortNumber(ref a, ref b, ref c);

            Console.WriteLine("{0},{1},{2}", a, b, c);

            Console.ReadKey();
        }
    }
}
/*
请输入第一个数：20
请输入第二个数：31
请输入第三个数：11
排序后：
31  20  11
*/
/*请输入第一个数：3
请输入第二个数：2
请输入第三个数：1
排序后：
1,2,3*/

/*请输入第一个数：2
请输入第二个数：3
请输入第三个数：1
排序后：
1,2,3*/


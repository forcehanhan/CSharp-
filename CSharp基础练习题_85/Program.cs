/*
 * 时    间：2020年3月10日00:51:05
 * 题    目：85.写一个洗牌程序.
 * 知 识 点：
 * 操作步骤：
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp基础练习题_85
{
    public class Poker
    {
        private string pokerType;
        private string pokerValue;
        public string PokerValue { get; set; }
        public string PokerType { get; set; }

        public Poker(string pt, string pv)
        {
            this.pokerType = pt;
            this.pokerValue = pv;
        }

        public override string ToString()
        {
            return pokerType + "" + pokerValue + " ";
        }
    }

    public class Program
    {
        public static Poker[] allPoker = new Poker[52];
        public static string[] pokerValue = new string[] { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A", };
        public static string[] pokerType = new string[] { "红桃", "黑桃", "梅花", "方片" };

        public static void Shuffle()
        {
            Random r = new Random();
            Poker temp;
            for (int i = 0; i < allPoker.Length; i++)
            {
                int ranIndex = r.Next(0, 52);
                temp = allPoker[i];
                allPoker[i] = allPoker[ranIndex];
                allPoker[ranIndex] = temp;
            }
        }

        public static void Init()
        {
            for (int i = 0; i < allPoker.Length; i++)
            {
                allPoker[i] = new Poker(pokerType[i % 4], pokerValue[i % 13]);
            }
        }
        public static void ShowPoker()
        {
            foreach (var item in allPoker)
            {
                Console.Write(item.ToString());
            }
        }
        public static void Main(string[] args)
        {
            Init();
            ShowPoker();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("---------洗牌---------");
            Init();
            Shuffle();
            ShowPoker();

            Console.ReadKey();
        }
    }
}
/*
红桃2 黑桃3 梅花4 方片5 红桃6 黑桃7 梅花8 方片9 红桃10 黑桃J 梅花Q 方片K 红桃A
黑桃2 梅花3 方片4 红桃5 黑桃6 梅花7 方片8 红桃9 黑桃10 梅花J 方片Q 红桃K 黑桃A
梅花2 方片3 红桃4 黑桃5 梅花6 方片7 红桃8 黑桃9 梅花10 方片J 红桃Q 黑桃K 梅花A
方片2 红桃3 黑桃4 梅花5 方片6 红桃7 黑桃8 梅花9 方片10 红桃J 黑桃Q 梅花K 方片A

---------洗牌---------
梅花3 红桃8 梅花8 黑桃J 梅花7 红桃2 方片J 红桃5 方片10 黑桃A 梅花6 方片9 梅花Q
方片3 方片4 黑桃10 梅花J 红桃K 梅花5 红桃A 红桃Q 梅花10 梅花2 黑桃6 黑桃Q 红桃3
梅花4 黑桃7 黑桃K 黑桃5 方片K 方片8 方片2 梅花K 红桃9 梅花A 红桃4 黑桃2 黑桃3 红
桃J 红桃7 方片7 黑桃4 方片5 方片6 黑桃8 黑桃9 梅花9 方片Q 方片A 红桃6 红桃10
*/
/*
红桃2 黑桃3 梅花4 方片5 红桃6 黑桃7 梅花8 方片9 红桃10 黑桃J 梅花Q 方片K 红桃A
黑桃2 梅花3 方片4 红桃5 黑桃6 梅花7 方片8 红桃9 黑桃10 梅花J 方片Q 红桃K 黑桃A
梅花2 方片3 红桃4 黑桃5 梅花6 方片7 红桃8 黑桃9 梅花10 方片J 红桃Q 黑桃K 梅花A
方片2 红桃3 黑桃4 梅花5 方片6 红桃7 黑桃8 梅花9 方片10 红桃J 黑桃Q 梅花K 方片A

---------洗牌---------
黑桃3 黑桃4 红桃K 红桃10 方片K 黑桃10 梅花K 方片9 红桃J 方片5 红桃5 梅花3 红桃6
梅花2 黑桃Q 梅花4 红桃9 黑桃A 方片A 方片4 方片2 红桃7 方片10 方片8 方片3 黑桃5
梅花A 黑桃8 红桃Q 黑桃9 黑桃J 梅花5 方片6 方片J 红桃8 梅花7 红桃2 黑桃2 黑桃7 梅
花Q 梅花J 红桃A 黑桃6 红桃3 红桃4 梅花9 方片Q 方片7 梅花6 梅花8 梅花10 黑桃K
*/

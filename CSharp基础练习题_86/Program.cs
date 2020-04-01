/*
 * 时    间：2020年3月11日15:52:26
 * 题    目：86.写一个洗牌程序.
 * 知 识 点：二周目
 * 操作步骤：
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp基础练习题_86
{
    /// <summary>Poker:扑克牌类</summary>
    class Poker
    {
        //扑克牌的花色:♥、♠、♣、♦
        private string pokerSuit;
        //扑克牌的牌点
        private string pokerPip;
        //封装字段
        public string PokerSuit { get { return pokerSuit; } set { pokerSuit = value; } }
        public string PokerPip { get { return pokerPip; } set { pokerPip = value; } }
        //初始化字段
        public Poker(string pokerSuit, string pokerPip) {
            this.pokerSuit = pokerSuit;
            this.pokerPip = pokerPip;
        }
        //输出某张牌(花色+牌点)
        public override string ToString() {
            return PokerSuit + "" + PokerPip + " ";
        }
    }//Poker
    class Program
    {
        //构造一副牌,一副牌主牌共52张。
        public static Poker[] allPoker = new Poker[52];
        public static string[] pokerSuit= new string[13] { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
        public static string[] pokerPip = new string[4] { "红桃", "黑桃", "梅花", "方片" };
        public static Poker temp;
        //洗牌
        public static void ShufflePoker() {
            //随机洗牌
            Random range = new Random();
            for (int i = 0; i < allPoker.Length; i++)
            {
                int rangeIndex = range.Next(52);//随机下标
                temp = allPoker[i];
                allPoker[i] = allPoker[rangeIndex];
                allPoker[rangeIndex] = temp;
            }
        }

        //初始化牌
        public static void InitPoker() {
            for (int i = 0; i < allPoker.Length; i++)
            {
                allPoker[i] = new Poker(pokerSuit[i % 4], pokerPip[i % 13]);
            }
        }

        //打印出洗好的牌
        public static void ShowPoker() {
            foreach (var item in allPoker)
            {
                Console.WriteLine(item.ToString());
            }
        }
        static void Main(string[] args) {
            InitPoker();
            ShufflePoker();
            ShowPoker();
            Console.ReadKey();
        }
    }
}

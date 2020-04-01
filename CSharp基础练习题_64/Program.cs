/*
 * 时    间：2020年3月6日11:34:07
 * 题    目：64.给定一个m*n的数值矩阵A，如果矩阵A中存在这样的一个元素A[i][j]满足条件: 
 *              A[i][j]是 第i行中值最小的元素，且又是第j列中值最大的元素，则称之为该矩阵的一个马鞍点。
 *              编写一个方法计算出m*n的矩阵A的所有马鞍点。
 * 知 识 点：
 * 操作步骤：
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp基础练习题_64
{
    class Program
    {
        static void Main(string[] args) {
            int m = 3;//m行
            int n = 4;//n列

            int i, j, max, min, temp;

            bool isEqual = false;

            int[,] A = {
                { 10, 20, 30, 11 },
                { 13, 3,  6,   8 },
                { 14, 15, 15, 14 }
            };

            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write("{0,2}  ", A[i, j]);
                }
                Console.WriteLine();
            }

            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    min = A[i, j];
                    max = A[i, j];

                    //A[i][j]是 第i行中值最小的元素

                    for (int k = 0; k < n; k++)
                    {
                        if (min > A[i, k])
                        {
                            min = A[i, k];
                        }
                    }

                    //A[i][j]是 第j列中值最大的元素
                    for (int k = 0; k < m; k++)
                    {
                        if (max < A[k, j])
                        {
                            max = A[k, j];
                        }
                    }

                    if (min == max)
                    {
                        Console.Write("\nmin:A[{0}][{1}]={2}\nmax:A[{0}][{1}]={3}\n ", i, j, min, max);
                        isEqual = true;
                    }

                }

            }
            if (isEqual != true)
            {
                Console.WriteLine("无马鞍点数。");
            }

            Console.ReadKey();
        }
    }//Program
}
//10  20  30  11
//13   3   6   8
//14  15  15  14

//min:a[2][0]=14
//max:a[2][0]=14

//min:a[2][3]=14
//max:a[2][3]=14

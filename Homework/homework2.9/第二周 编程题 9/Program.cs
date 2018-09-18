using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第二周_编程题_9                  //埃氏筛法
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j,k;
            i = 0;
            int[] primeNumber;
            primeNumber = new int[100];
            for(k = 2;k <= 100;k++)
            {
                primeNumber[i] = k;
                i++;
            }
            for(j = 2;j <= 100;j++)
            {
                for(i = 0;i < 100;i++)
                {
                    if(primeNumber[i] % j == 0 && primeNumber[i]!=j)
                    {
                        primeNumber[i] = 1;
                    }
                }
            }
            Console.Write("There are prime number:");
            for (i = 0;i < 100;i++)
            {
                if (primeNumber[i] != 1)
                {
                    Console.Write(primeNumber[i]+",");
                }
            }
        }
    }
}

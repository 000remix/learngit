using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第二周_编程题_6                    //输出用户指定数据的所有因子
{
    class Program
    {
        static bool PrimeNumber(int n)
        {
            int i;
            for(i = 2; i < n; i++)
            {
                if(n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            int x,i;
            string s;
            int [] factor;
            factor = new int[32];
            Console.Write("Please input a prime number: ");
            s = Console.ReadLine();
            x = Int32.Parse(s);
            int y = x;
            int j = 0;
            while (y != 1)
            {
                for(i = 2; i < y; i++)
                {
                    if(y%i == 0 && PrimeNumber(i))
                    { break; }
                }
                factor[j++] = i;
                y = y / i;
            }
            Console.Write(x + "=" );
            for (i = 0;i < j;i++ )
            {
                if(i == (j - 1))
                {
                    Console.WriteLine(factor[i] + "\n");
                    break;
                }
                Console.Write(factor[i]);
                Console.Write("*");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第二张_编程题_7
{
    class Program
    {
        static int Max(int [] n)
        {
            int L = n.Length;
            int i, j, t;
            for(i=0;i<L;i++)
            {
                if (n[i] > n[i + 1])
                {
                    t = n[i + 1];
                    n[i + 1] = n[i];
                    n[i] = t;
                }
            }
            j = n[i];
            Console.WriteLine("The maximum in this arry is" + j);
            return j;
        }
        static int Min(int[] n)
        {
            int L = n.Length;
            int i, j, t;
            for (i = 0; i < L; i++)
            {
                if (n[i] < n[i+1])
                {
                    t = n[i + 1];
                    n[i + 1] = n[i];
                    n[i] = t;
                }
            }
            j = n[i];
            Console.WriteLine("The minimum in this arry is" + j);
            return j;
        }

        static int Sum(int[] n)
        {
            int L = n.Length;
            int i;
            int j = 0;
            for (i = 0; i < L; i++)
            {
                j += i;
            }
            Console.WriteLine("The sum of this arry is" + j);
            return j;
        }

        static int Average(int[] n)
        {
            int L = n.Length;
            int i = Sum(n)/L;
            Console.WriteLine("The Average of this arry is" + i);
            return i;
        }

        static void Main(string[] args)
        {
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2
{
    internal class Egypt
    {
        static void Main(string[] args)
        {
            int limit = 100;
            bool[] isPrime = new bool[limit + 1];

            for (int i = 2; i <= limit; i++)
            {
                isPrime[i] = true;
            }

            for (int i = 2; i * i <= limit; i++)
            {
                if (isPrime[i])
                {
                    for (int j = i * i; j <= limit; j += i)
                    {
                        isPrime[j] = false;
                    }
                }
            }

            Console.WriteLine("2 到 100 以内的素数为：");
            for (int i = 2; i <= limit; i++)
            {
                if (isPrime[i])
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2
{
    internal class PrimeFactor
    {
        static void Main()
        {
            Console.WriteLine("正整数:");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine($"{number}的素数因子为：");
            PrintPrimeFactors(number);
        }
        static void PrintPrimeFactors(int num)
        {
            for (int i = 2; i <= num; i++)
            {
                while (num % i == 0)
                {
                    Console.WriteLine(i + " ");
                    num /= i;
                }
            }
            Console.WriteLine();
        }
    }
}

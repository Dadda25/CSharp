using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2
{
    internal class Array
    {
        static void Main(string[] args)
        {
            Console.Write("请输入数组元素：");
            string input = Console.ReadLine();

            string[] inputArray = input.Split(' ');
            int[] numbers = new int[inputArray.Length];

            for (int i = 0; i < inputArray.Length; i++)
            {
                numbers[i] = int.Parse(inputArray[i]);
            }

            int max = numbers[0];
            int min = numbers[0];
            int sum = 0;

            foreach (int num in numbers)
            {
                if (num > max)
                    max = num;
                if (num < min)
                    min = num;
                sum += num;
            }

            double average = (double)sum / numbers.Length;

            Console.WriteLine($"数组的最大值: {max}");
            Console.WriteLine($"数组的最小值: {min}");
            Console.WriteLine($"数组元素的平均值: {average:F4}");
            Console.WriteLine($"数组元素的和: {sum}");
        }
    }
}

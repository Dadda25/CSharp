using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2
{
    internal class Matrix
    {
        public bool IsToeplitzMatrix(int[][] matrix)
        {
            int rows = matrix.Length;
            int cols = matrix[0].Length;

            for (int i = 1; i < rows; i++)
            {
                for (int j = 1; j < cols; j++)  
                {
                    if (matrix[i][j] != matrix[i - 1][j - 1]) 
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        static void Main(string[] args)
        {
            Matrix solution = new Matrix();

            Console.Write("请输入矩阵的行数: ");
            int rows = int.Parse(Console.ReadLine());

            Console.Write("请输入矩阵的列数: ");
            int cols = int.Parse(Console.ReadLine());

            int[][] matrix = new int[rows][];

            Console.WriteLine("请输入矩阵的每一行：");

            for (int i = 0; i < rows; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                matrix[i] = new int[cols];
                for (int j = 0; j < cols; j++)
                {
                    matrix[i][j] = int.Parse(input[j]);
                }
            }

            bool result = solution.IsToeplitzMatrix(matrix);

            Console.WriteLine(result ? "True" : "False");
        }
    }
}

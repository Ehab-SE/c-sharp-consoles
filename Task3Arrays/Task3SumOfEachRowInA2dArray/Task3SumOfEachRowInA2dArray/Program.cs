using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3SumOfEachRowInA2dArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] numbers = { { 3, 5, 10 }, { 6, 7, 8 }, { 12, 7, 4 } };
           
            for (int row = 0; row < numbers.GetLength(0); row++)
            {
                int sum = 0;
                for (int col = 0; col < numbers.GetLength(1); col++)
                {
                    sum += numbers[row, col];
                }
                Console.WriteLine($"Row {row+1} sum = {sum}");
            }
        }
    }
}

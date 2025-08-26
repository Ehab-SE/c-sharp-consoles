using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5DiagonalElementsofa2DArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix ={ { 1, 2, 3 },{ 4,5,6},
            { 7,8,9} };
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                Console.Write($"{matrix[i, i]}, ");
            }
        }
    }
}

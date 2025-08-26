using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace Task4SearchForaNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 5, 7, 10, 15, 6, 9, 17, 13 };
            Console.WriteLine("Enter an integer number");
            int num = int.Parse(Console.ReadLine());
            int counter = 0;
            foreach (var item in numbers)
            {
                if (num == item)
                {
                    Console.WriteLine($"The number {num} found in the array");
                    break;
                }
                else {
                    counter++;
                        
                    }
                
            }
            if (counter == 8) { Console.WriteLine($"The number {num} is not in the array"); }
        }
    }
}

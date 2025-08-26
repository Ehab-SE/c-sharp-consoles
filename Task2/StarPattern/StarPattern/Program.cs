using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int num = int.Parse(Console.ReadLine());
            string line = "";
            for (int i = 0; i < num; i++) {
                line += "*";
                Console.WriteLine(line);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace GuessTheNumberGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int randomNumber =rnd.Next(1, 50);

            Console.WriteLine("Guss a number between 1 and 50");
            int num;
            int tryCount = 0;
            do
            {
                num = int.Parse(Console.ReadLine());
                if(num > randomNumber)
                {
                    Console.WriteLine("Too high!");
                    
                }
                else if(num < randomNumber)
                {
                    Console.WriteLine("Too low!");
                }else if(num == randomNumber)
                {
                    Console.WriteLine($"\nWOW, done, the number is {num}\n");
                }
                tryCount++;
            } while (num != randomNumber);
            Console.WriteLine($"You tries {tryCount} times");

                
             

        }
    }
}

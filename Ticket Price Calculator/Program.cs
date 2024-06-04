using System;

namespace TicketPriceCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age <= 12 || age >= 65)
            {
                Console.WriteLine("Your ticket price is GHC7.");
            }
            else
            {
                Console.WriteLine("Your ticket price is GHC10.");
            }
        }
    }
}
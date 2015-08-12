using System;
using Microsoft.SqlServer.Server;

namespace CSExercises
{
    public class Ex45
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter the amount: ");
            double amount = Convert.ToDouble(Console.ReadLine());

            long amountInCents = Convert.ToInt64(Math.Ceiling(amount*100));

            while (amountInCents > 100)
            {
                Console.WriteLine("100c");
                amountInCents -= 100;
            }
            while (amountInCents > 50)
            {
                Console.WriteLine("50c");
                amountInCents -= 50;
            }
            while (amountInCents > 20)
            {
                Console.WriteLine("20c");
                amountInCents -= 20;
            }
            while (amountInCents > 10)
            {
                Console.WriteLine("10c");
                amountInCents -= 10;
            }
            while (amountInCents > 5)
            {
                Console.WriteLine("5c");
                amountInCents -= 5;
            }
            if (amountInCents != 0)
            {
                //give extra five cents :)
                Console.WriteLine("5c");
            }
        }
    }
}

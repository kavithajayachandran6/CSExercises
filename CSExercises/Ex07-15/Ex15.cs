using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex15
    {
        public static void Main(string[] args)
        {
            
            
            Console.WriteLine("Enter a three digit no:");
            int num=Convert.ToInt32(Console.ReadLine());
            if (num < 1000 && num > 99)
            {


                int a1 = num / 100;
                int a2 = (num / 10) % 10;
                int a3 = num % 10;
                if((Math.Pow(a1, 3) + Math.Pow(a2, 3) + Math.Pow(a3, 3))==num)
                {
                    Console.WriteLine("The number is an armstrong no");

                }else
                    Console.WriteLine("The number is not an armstrong no");
            }
        }
    }
}
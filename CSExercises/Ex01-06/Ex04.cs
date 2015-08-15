using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex04
    {
        public static void Main(string[] args)
        {
            double num = 0;
            Console.WriteLine("Keyin an inetger ");
            String numString = Console.ReadLine();
            num = Convert.ToDouble(numString);
            double sqnum = num * num;
            Console.WriteLine("The square of " + num + " =" + sqnum); 
        }
    }
}

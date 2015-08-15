using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex05
    {
        public static void Main(string[] args)
        {
            double num = 0;
            Console.WriteLine("Keyin an inetger ");
            String numString = Console.ReadLine();
            num = Convert.ToDouble(numString);
            double sqnum = Math.Sqrt(num);
            Console.WriteLine("The square of " + num + " = {0:#.###}", sqnum); 
           
        }
    }
}

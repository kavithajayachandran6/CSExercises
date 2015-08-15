using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex08
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Key in tempartaure in Centigrade");
            double centigrade=Double.Parse(Console.ReadLine());
            double Fa = 1.8 * centigrade + 32;
            Console.WriteLine("The Fahrenheit equivalent is " + Fa);
            
        }
    }
}

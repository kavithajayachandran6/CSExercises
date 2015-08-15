using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex07
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Key in Salary");
            String salary=Console.ReadLine();
            double sal=Double.Parse(salary);
            double hallow = 0.1 * sal;
            double tallow = 0.03 * sal;
            double totalsal = sal + hallow + tallow;
            Console.WriteLine("The total salary ${0}", totalsal);
            
        }
    }
}

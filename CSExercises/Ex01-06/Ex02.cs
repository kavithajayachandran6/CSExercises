using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex02
    {
        public static void Main(string[] args)
        {
            int num = 0;
            Console.WriteLine("Keyin an inetger ");
            String numString = Console.ReadLine();
            num = Convert.ToInt32(numString);
            int sqnum = num * num;
            Console.WriteLine("The square of " + num + " =" + sqnum);
        }
    }
}

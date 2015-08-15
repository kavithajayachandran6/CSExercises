using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex10
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Key in the Four Coordinates:");
            double x1=Double.Parse(Console.ReadLine());
            double x2 = Double.Parse(Console.ReadLine());
            double y1 = Double.Parse(Console.ReadLine());
            double y2 = Double.Parse(Console.ReadLine());
            double dist = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine("distance between the coordinates:" + dist);
            
        }
    }
}

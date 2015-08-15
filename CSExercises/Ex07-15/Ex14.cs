using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex14
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the length of side A:");
            Double sideA = Double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the length of side B:");
            Double sideB = Double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the length of side C:");
            Double sideC = Double.Parse(Console.ReadLine());
            double s = (sideA + sideB + sideC) / 2;
            if ((sideA + sideB) > sideC && (sideB + sideC) > sideA && (sideC + sideA) > sideB)
            {
                double area = Math.Sqrt(s * (s - sideA) * (s - sideB) * (s - sideC));
                Console.WriteLine("Area of triangle=" + area);
            }
            else
                Console.WriteLine("Number keyed in cannot form a triangle");
        }
    }
}
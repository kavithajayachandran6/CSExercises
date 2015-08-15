using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex11
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Key in the distance travelled:");
            double d= Double.Parse(Console.ReadLine());
            double fare = 2.4 + d * 0.4;
            Console.WriteLine("Total fare for Distance travelled" + fare);
            
        }
    }
}

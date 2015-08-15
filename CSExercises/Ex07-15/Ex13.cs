using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex13
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Key in the distance travelled:");
            double d = Double.Parse(Console.ReadLine());
            double value =2.4 + d * 0.4;
            double roundedvalue=Math.Ceiling(value);
            Console.WriteLine("Fare rounded upwards for distance travelled is  {0:0.00} ",roundedvalue);
        }
    }
}

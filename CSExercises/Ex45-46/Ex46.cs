using System;

namespace CSExercises
{
    public class Ex46
    {
        public static void Main(string[] args)
        {
            int[] counts= new int[10];
            int[] numbers = new int[50];

            Random rnd = new Random();
            for (int i = 0; i < 50; i++)
            {
                numbers[i] = rnd.Next(0, 10);
                counts[numbers[i]] ++;
            }

            Console.WriteLine("Number\tCount");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("{0}\t{1}",i,counts[i]);
            }

            for (int i = 0; i < 10; i++)
            {
                string stars="";
                for (int j = 0; j < counts[i]; j++) stars += "*";
                Console.WriteLine("{0}\t{1}", i, stars);
            }

        }
    }
}

namespace CSExercises
{
    public class Ex39
    {
        public static long Factorial(long n)
        {
            long result = 1;
            for (long i = n; i > 1; i--)
            {
                result *= i;
            }

            return result;
        }
    }
}

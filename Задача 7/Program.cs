namespace Задача_7
{
    internal class Program
    {
        static int Factorial(int k)
        {
            if (k == 0) return 1;
            int result = 1;
            for (int i = 1; i <= k; i++)
            {
                result *= i;

            }
            return result;
        }
        static double SumOfSeries(int n)
        {
            double sum = 0;
            for (int i = 0; i <= n; i++)
            {
                sum += 1.0 / Factorial(i);
            }
            return sum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(SumOfSeries (5));
        }
    }
}

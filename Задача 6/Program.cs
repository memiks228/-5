namespace Задача_6
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
        static long SumOfFactorials(int n)
        {
            long sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += Factorial(i);
            }
            return sum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(SumOfFactorials (5));
        }
    }
}

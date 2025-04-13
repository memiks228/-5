namespace Задача_5
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
        static void Main(string[] args)
        {
           Console.WriteLine( Factorial(5));

        }
    }
}

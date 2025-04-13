namespace Задача_10
{
    internal class Program
    {
        static int Square(int n)
        {
            return n * n;
        }
        static double SumSeries(int n)
        {
            double sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += (i % 2 == 0 ? -1.0 / i : 1.0 / i);
            }
            return sum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(SumSeries(5));
        }
    }
}

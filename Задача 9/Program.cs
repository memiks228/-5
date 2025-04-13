namespace Задача_9
{
    internal class Program
    {
        static int Square(int n)
        {
            return n * n;
        }
        static int SumOfSquares(int n)
        {
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += Square(i);
            }
            return sum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(SumOfSquares(5));
        }
    }
}

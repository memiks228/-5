namespace Задача_12
{
    internal class Program
    {
        static void PrintDigits(int N)
        {
            N = int.Parse(Console.ReadLine());

            while (N > 0)
            {
                Console.Write(N % 10 + " ");
                N /= 10;
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {

            PrintDigits(0);
            
        }
    }
}

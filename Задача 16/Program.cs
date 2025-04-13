namespace Задача_16
{
    internal class Program
    {
        static void Fibonacci(int M)
        {
            M = int.Parse(Console.ReadLine());

            int a = 0, b = 1;

            while (a <= M)
            {
                Console.Write(a + " ");
                int temp = a;
                a = b;
                b = temp + b;
            }

            Console.WriteLine();
        }
        static void Main(string[] args)
        {
             
            Fibonacci(0);

        }
    }
}

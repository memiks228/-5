namespace Задача_4
{
    internal class Program
    {
        static void PrintNumbers(int M, int N)

        {
            N = int.Parse(Console.ReadLine());
            M = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                Console.Write(M + " ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
            
        {

            PrintNumbers(0,0);
        }
    }
}

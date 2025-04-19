
namespace Задача_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            if (n <= 0)
            {
                Console.WriteLine("отрицательные числа отсуствуют ");
            }
            int[] a = new int[n];
            if (a.Length >= 1)
                a[0] = 0;
            if (a.Length >= 2)
                a[1] = 1;

            for (int i = 2; i < a.Length; i++)
            {
                a[i] = a[i - 1] + a[i - 2];
            }
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }
        }
    }
}
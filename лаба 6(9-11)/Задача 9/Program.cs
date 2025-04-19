namespace Задача_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int n = int.Parse(Console.ReadLine());
            if (n <= 0)
            {
                Console.WriteLine("отрицательные числа отсуствуют ");
            }
            int[] a = new int[n];
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = rnd.Next(0, 11);
                Console.Write(a[i] + " ");
            }
            bool value = true;
            for (int i = 0; i < n; i++)
            {
                if (a[i] % 2 != 0)
                {
                    value = false;
                }
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(value);
        }
    }
}
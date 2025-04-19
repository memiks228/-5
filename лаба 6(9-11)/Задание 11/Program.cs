namespace Задание_11
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
                a[i] = rnd.Next(0, 51);
                Console.Write(a[i] + " ");
            }
            int z = 0; 
            for (int i = 0; i < n; i++)
            {
                if (a[i] % 2 == 0)
                {
                    z++;
                }
            }
            int[] b = new int[z];
            int ind = 0;
            for (int i = 0; i < n; i++)
            {
                if (a[i] % 2 == 0)
                {
                    b[ind] = a[i];
                    ind++;
                }
            }
            Console.WriteLine();
            if (b.Length == 0)
            {
                Console.WriteLine("Четные числа отсуствуют");
            }
            else
            {
                Console.WriteLine(string.Join(" ", b)); 
            }
        }

    }
}
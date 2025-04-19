 namespace Задача_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] a = new int[17];
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = rnd.Next(-10, 10 + 1);
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
            double sum = 0;
            int z = 0;
            for (int i = 0; i < a.Length; i += 2) 
            {
                if (a[i] > 0 && a[i] % 2 != 0)
                {
                    sum += a[i];
                    z++;
                }
            }
            if (z > 0)
            {
                double arif = sum / z; 
                Console.WriteLine(arif);
            }
        }
    }
}
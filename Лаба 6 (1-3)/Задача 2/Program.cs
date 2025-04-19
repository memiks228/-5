namespace Задача_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] a = new double[8];
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = double.Parse(Console.ReadLine());
            }
            double sum = 0;
            int z = 0; 
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > 0)
                {
                    sum += a[i];
                    z++; 
                }
            }
            double arif = sum / z;
            Console.WriteLine($"Среднее", arif);
        }
    }
}
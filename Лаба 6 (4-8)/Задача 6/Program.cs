namespace Задача_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] a = new int[15];
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = rnd.Next(20, 301);
                Console.Write(a[i] + " ");
            }
            int min = a[0];
            int mini = 0;
            for (int i = 1; i < a.Length; i++) 
            {
                if (a[i] < min)
                {
                    min = a[i];
                    mini = i;
                }
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(min);
            Console.WriteLine(mini + 1);
        }
    }
}
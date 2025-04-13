namespace Задача_20
{
    internal class Program
    {
        static double Distance(int N)
        {
            double distance = 10; 

            for (int i = 2; i <= N; i++)
            {
                distance *= 1.10; 
            }

            return distance;
        }
        static double Total(int N)
        {
            double total = 0;

            for (int i = 1; i <= N; i++)
            {
                total += Distance(i);
            }

            return total;
        }
    

    static void Main(string[] args)
        {
            Console.WriteLine(Distance(10));
            Console.WriteLine(Total(10));


        }
    }
}
    


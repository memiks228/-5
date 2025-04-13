namespace Задача_21
{
    internal class Program
    {
        static double distance(int N)
        {
            N = int.Parse(Console.ReadLine());
            double dist = 0;

            for (int i = 1; i <= N; i++)
            {
                if (i % 2 == 1) 
                {
                    dist += 1.0 / i; 
                }
                else 
                {
                    dist -= 1.0 / i; 
                }
            }

            return dist;
        }

        static double total(int N)
        {
            N = int.Parse(Console.ReadLine());

            double totalDistance = 0;

            for (int i = 1; i <= N; i++)
            {
                totalDistance += 1.0 / i; 
            }

            return totalDistance;
        }
    
    static void Main(string[] args)
        {
            Console.WriteLine(distance(0));
            Console.WriteLine(total(0));
        }
    }
}


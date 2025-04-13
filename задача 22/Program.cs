namespace задача_23
{
    internal class Program
    {
        public static double Perimeter(double a, double b, double c)
        {
            return a + b + c;
        }

        public static void Main()
        {
            Console.WriteLine(Perimeter(3,4,5));
        }
    }
}
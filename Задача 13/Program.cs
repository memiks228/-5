namespace Задача_13
{
    internal class Program
    {
        static string DecimalToBinary(int number)
        {
            number = int.Parse(Console.ReadLine());
            string binary = "";
            while (number > 0)
            {
                binary = (number % 2) + binary;
                number /= 2;
            }
            return binary;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(DecimalToBinary(0));
        }
    }
}

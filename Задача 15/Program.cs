namespace Задача_15
{
    internal class Program
    {
        static int GetValidNumber(int number)
        {
            
            do
            {
                number = int.Parse(Console.ReadLine());
                if (number < 1 || number > 100)
                    Console.Write("Некорректное число. Попробуйте снова: ");
            } while (number < 1 || number > 100);

            return number;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(GetValidNumber(0));
        }
    }
}

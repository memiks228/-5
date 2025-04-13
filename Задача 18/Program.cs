namespace Задача_18
{
    internal class Program
    {
        static double Weight(int itemsCount)
        {

             itemsCount = int.Parse(Console.ReadLine());

            double totalWeight = 0;

            for (int i = 0; i < itemsCount; i++)
            {

                totalWeight += double.Parse(Console.ReadLine());
            }

            return totalWeight / itemsCount;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Weight(0));
        }
    }
}

namespace Задача_17
{
    internal class Program
    {
        static double Grade(int subjectsCount)
        {
            double totalGrades = 0;

            for (int i = 0; i < subjectsCount; i++)
            { 
                totalGrades += double.Parse(Console.ReadLine());
            }

            return totalGrades / subjectsCount;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Grade(10));
        }
    }
}

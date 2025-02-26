namespace SumaNaOburnatiChisla
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a list of numbers: ");
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            for (int i = 0; i < numbers.Count; i++)
            { 
                while (numbers[i] != 0)
                {

                }
            }

        }
    }
}

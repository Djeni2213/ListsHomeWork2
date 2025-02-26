namespace SpisukOtKrainosti
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a list of numbers: ");
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int min = 1000000000;
            int max = -100000000;

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] < min)
                {
                    min = numbers[i]; 
                }
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }
            Console.Write($"{min} {max}");
        }
    }
}

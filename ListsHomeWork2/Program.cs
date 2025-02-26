namespace EvenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a lst of numbers: ");
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            List<int> evenNumbers = new List<int>();
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    evenNumbers.Add(numbers[i]);
                }
            }
            Console.WriteLine(string.Join(", ", evenNumbers));
        }
    }
}

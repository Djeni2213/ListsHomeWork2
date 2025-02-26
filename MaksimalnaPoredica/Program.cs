namespace MaksimalnaPoredica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a list of numbers: ");
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            for (int i = 1; i < numbers.Count; i++)
            {

            }

        }
    }
}

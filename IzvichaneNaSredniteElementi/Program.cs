using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IzvichaneNaSredniteElementi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(',').Select(int.Parse).ToArray();
            int n = nums.Length;

            if(nums.Length == 1)
            {
                Console.WriteLine(nums[0]);
            }
            int midIndex = n / 2;
            if (n % 2 == 0)
            {
                Console.WriteLine($"{nums[midIndex-1]} {nums[midIndex]}");
            }
            else
            {
                Console.WriteLine($"{nums[midIndex-1]} {nums[midIndex]} {nums[midIndex+1]}");
            }



            //for (int i = 0; i < nums.Length; i++)
            //{
            //    Console.Write($"{nums[i]}, ");
            //}

        }
    }
}

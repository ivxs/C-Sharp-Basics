using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var sum = 0;
            var min = arr[0];
            var max = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (min > arr[i])
                {
                    min = arr[i];
                }
                else if (max < arr[i])
                {
                    max = arr[i];
                }

            }
            var average = sum / arr.Length;
            Console.WriteLine($"Sum = {sum}");
            Console.WriteLine($"Min value = {min}");
            Console.WriteLine($"Max value = {max}");
            Console.WriteLine($"Average = {average}");
        }
    }
}

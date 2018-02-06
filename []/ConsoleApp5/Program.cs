using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var sum = arr.Sum();
            var min = arr.Min();
            var max = arr.Max();
            var average = arr.Average();
            Console.WriteLine($"Sum = {sum}");
            Console.WriteLine($"Min value = {min}");
            Console.WriteLine($"Max value = {max}");
            Console.WriteLine($"Average = {average}");
            
        }
    }
}

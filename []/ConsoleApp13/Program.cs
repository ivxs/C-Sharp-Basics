using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var sum1 = 0;
            var sum2 = 0;
            for (int i = 0; i < arr.Length - 2; i++)
            {
                sum1 += arr[i];
            }
            for (int i = 2; i < arr.Length; i++)
            {
                sum2 += arr[i];
            }
            Console.WriteLine($"{sum1} {sum2}");
            
        }
    }
}

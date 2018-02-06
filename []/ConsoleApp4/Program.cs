using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(' ');
            for (int i = 0; i < arr.Length / 2; i++)
            {
                var currentElement = arr[arr.Length - 1 - i];
                arr[arr.Length - 1 - i] = currentElement;
                arr[i] = currentElement;
            }
            Console.WriteLine(string.Join(" ", arr));
        }
    }
}

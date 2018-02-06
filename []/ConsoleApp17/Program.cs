using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split(' ');
            long[] quantity = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            double[] price = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            string product = Console.ReadLine();
            while (product != "done")
            {
                
                var index = Array.IndexOf(names, product);
                Console.WriteLine($"{product} costs: {price[index]}; Available quantity : {quantity[index]}");
                product = Console.ReadLine();
            }
        }
    }
}

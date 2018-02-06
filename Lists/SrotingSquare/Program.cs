using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SrotingSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            var list1 = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToList();
            var result = new List<int>();
            foreach (var num in list1)
            {
                if (num == Math.Sqrt(num) * Math.Sqrt(num))
                {
                    result.Add(num);
                }
            }
            result.Sort();
            result.Reverse();
            Console.WriteLine(string.Join(" ", result));
        }
    }
}

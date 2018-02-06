using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            var list1 = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToList();
            list1.Sort();
            Console.WriteLine(string.Join(" <= ", list1));
        }
    }
}

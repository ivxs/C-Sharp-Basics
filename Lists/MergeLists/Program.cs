using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeLists
{
    class Program
    {
        static void Main(string[] args)

        {
            var list1 = Console.ReadLine().Trim().Split(new char[] { '|' } , StringSplitOptions.RemoveEmptyEntries).ToList();
            list1.Reverse();
            var result = string.Join(" ", list1).Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine(string.Join(" ", result));
        }
    }
}

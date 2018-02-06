using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveAllNegative
{
    class Program
    {
        static void Main(string[] args)
        {
            var list1 = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToList();
            list1.RemoveAll(x => x < 0);
            Console.WriteLine(list1.Count > 0 ? string.Join(" ",list1) : "Empty");
        }
    }
}

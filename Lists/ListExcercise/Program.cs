using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExcercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var list1 = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToList();

            for (int i = 0; i < list1.Count; i++)
            {
                Console.WriteLine($"list1[{i}] = {list1[i]}");
            }
         

        }
    }
}

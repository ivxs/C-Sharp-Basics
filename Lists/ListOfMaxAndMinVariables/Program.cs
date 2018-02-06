using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListOfMaxAndMinVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            var list1 = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToList();
            var list2 = new List<int>();
            var min = list1.Min();
            var max = list1.Max();
            for (int i = 0; i < list1.Count; i++)
            {
                if (list1[i] == max)
                {
                    list2.Add(list1[i]);
                }
                else if (list1[i] == min)
                {
                    list2.Add(list1[i]);
                }
            }
            Console.WriteLine(string.Join(" ", list2));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberOfNums
{
    class Program
    {
        static void Main(string[] args)
        {
            var list1 = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToList();
            var nums = 1;
            
            list1.Sort();
            var list2 = new List<string>();
            for (int i = 0; i < list1.Count; i++)
            {
                if(list1[i] == list1[i + 1])
                {
                    nums++;
                }
                else
                {
                    var element = list1[i];
                    list2.Add($"{element} -> {nums}");
                    nums = 1;
                    
                }
            }
            Console.WriteLine(string.Join("\n", list2));
        }
    }
}

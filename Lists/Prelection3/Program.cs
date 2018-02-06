using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prelection3
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToList();
            int start = 0;
            int lenght = 1;
            int lenght1 = 0;
            var start1 = 0;
            var lastNum = nums[0];
            
            for (int i = 0; i < nums.Count; i++)
            {
                
                if (lastNum == nums[i])
                {
                    lenght++;
                    start = i - 1;
                }
                else
                {
                    lenght = 1;
                    start = i;
                }
                if (lenght > lenght1)
                {
                    lenght1 = lenght;
                    start1 = start - i;
                }
            }
            var result = new List<int>();
            result = nums.Skip(start1).Take(lenght1).ToList();
            Console.WriteLine(string.Join(" ",result));  
        }
    }
}

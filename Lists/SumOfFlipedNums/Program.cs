using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfFlipedNums
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToList();
            var newNums = new List<int>();
            
            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i] < 100 && nums[i] >= 10)
                {

                    var current = nums[i];
                    var num = (current / 10) + (current % 10) * 10;
                    newNums.Add(num);
                    
                }
                else if (nums[i] >= 100)
                {
                    var current = nums[i];
                    var num = (current % 10) * 100 + ((current / 10) % 10) * 10 + (current / 100);
                    newNums.Add(num);
                    
                }
            }
            var total = newNums.Sum();
            Console.WriteLine(total);
        }
    }
}

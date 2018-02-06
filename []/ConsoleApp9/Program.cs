using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int sum = 0;
            for (int i = 0; i < nums.Length - 1; i++)
            {
               int condensed = nums[i] + nums[i + 1];
                sum += condensed;
            }
            Console.WriteLine(sum);
            
        }
    }
}

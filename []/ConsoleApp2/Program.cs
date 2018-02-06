using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            int[] nums = new int[count];
            for (int i = 0; i < count; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());
                nums[i] = currentNum;
            }
            for (int i = nums.Length - 1 ; i >= 0 ; i--)
            {
                Console.Write(nums[i] + " ");
            }
        }
    }
}

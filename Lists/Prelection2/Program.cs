using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prelection2
{
    class Program
    {
        static void Main(string[] args)
        {
           var nums = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToList();
            for (int i = 0; i < nums.Count; i++)
            {
                
            }
            Console.Write(string.Join(", ", nums));


            // string input = Console.ReadLine();
            // string[] arr = input.Split(' ');
            // var listOfNums = new List<int>();

            // for (int i = 0; i < arr.Length; i++)
            // {
            //     listOfNums.Add(int.Parse(arr[i]));
            // }
            //both metods are the same
        }
    }
}

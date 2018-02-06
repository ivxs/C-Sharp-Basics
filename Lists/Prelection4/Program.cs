using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prelection4
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToList();
            int lastElement = num.Last();
            
           // while (num.Contains(lastElement))
           // {
           //     num.Remove(lastElement);
            //}
           
            Console.WriteLine(string.Join(" ", num));
        
        }
    }
}

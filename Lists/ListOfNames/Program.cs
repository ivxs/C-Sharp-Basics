using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListOfNames
{
    class Program
    {
        static void Main(string[] args)
        {
            var list1 = Console.ReadLine().Split().ToList();
            for (int i = 0; i < list1.Count; i++)
            {
                
            }
            Console.WriteLine(string.Join("; ",list1));
        }
    }
}

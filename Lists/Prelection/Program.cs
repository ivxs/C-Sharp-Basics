using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prelection
{
    class Program
    {
        static void Main(string[] args)
        {

            var list1 = new List<string>() { "Pesho", "Ivan", "Ivan", "Martin", "Stamat", "Valkan","Sasho","Sashka" };
            list1.Add("Petko");
            list1.Add("Rado");
            list1.Add("Viktor");
            var count = list1.Count;
            list1.RemoveAt(3);
            list1.RemoveAll(x => x == "Ivan");
            list1.Insert(3, "Mitko");
            if (list1.Contains("Mitko"))
            {
                Console.WriteLine("Mitko is here");
            }
            list1.Sort();
            list1.Reverse();

            Console.WriteLine(list1.Count);
        }
    }
}

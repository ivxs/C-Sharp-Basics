using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lection
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            bool isTrue = Convert.ToBoolean(input);
            Console.WriteLine(isTrue ? "Yes" : "No");
        }
    }
}

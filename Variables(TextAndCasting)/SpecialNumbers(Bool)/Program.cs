using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialNumbers_Bool_
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            bool isTrue = Convert.ToBoolean(input);
            Console.WriteLine(isTrue ? "Yes" : "No");
            //If we put (!) infront of (isTrue) we will write (Yes) when it is false

        }
    }
}

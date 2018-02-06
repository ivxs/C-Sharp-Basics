using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] days = { "Monday", "Tuesday", "Wednesday", "Thirsday", "Friday", "Saturday", "Sunday" };
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(days[n-1]);
        }
    }
}

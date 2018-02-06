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
            int people = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());

            int courses = (int)Math.Ceiling((double)people / capacity);
            if (people <= capacity)
            {
                Console.WriteLine("All people can fit into the elevator. One course is enough.");
            }
            else
            {
                Console.WriteLine($"It would need {courses} courses to transport all people.");
            }
            //Another way of doing it is:
            //int people = int.Parse(Console.ReadLine());
            //int capacity = int.Parse(Console.ReadLine());
            //int courses = people / capacity;
            //if (people % capacity !=0) {
            //courses++
            //}
            //Console.WriteLine(courses);

        }
    }
}

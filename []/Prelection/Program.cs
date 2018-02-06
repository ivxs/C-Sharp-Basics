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
            int[] num = { 5 };
            Increment(num, 15);
            Console.WriteLine(num[0]);

        }
        private static void Increment(int[] num, int value)
        {
            num[0] += value;

        }
        static void Whatever(string[] args)
        {
            // reverses whole array
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Array.Reverse(arr);
            Console.WriteLine(arr);
        }
        static void Whatever1(string[] args)
        {
            // sort from smallest to largest
            int[] arr = { 2, 1, 3, 4, 5, 6, 7, 8, 9, 10 };
            Array.Sort(arr);
            Console.WriteLine(string.Join(" ", arr));

        }
        static void Whatever2(string[] args)
        {
            // clears (array) starting from (index 2) 3 after that (only in this case)
            int[] arr = { 2, 1, 3, 4, 5, 6, 7, 8, 9, 10 };

            Array.Clear(arr, 2, 3);
            Console.WriteLine(string.Join(" ", arr));
        }
        static void Whatever3(string[] args)
        {
            //copies from (index 11 to end) arr to arr1
            int[] arr = { 2, 1, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] arr1 = { 3, 4, 2, 3, 4, 6, 5, 4, 6, 3, 2134, 1, 41234, 124 };
            arr.CopyTo(arr1, 11);
            Console.WriteLine(string.Join(" ", arr1));

        }
        static void Whatever4(string[] args)
        {
            //copies
            int[] arr = { 2, 1, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] arr1 = { 3, 4, 2, 3, 4, 6, 5, 4, 6, 3, 2134, 1, 41234, 124 };
            Array.Copy(arr, 4, arr1, 3, 2);
            Console.WriteLine(string.Join(" ", arr1));

        }
    }
}

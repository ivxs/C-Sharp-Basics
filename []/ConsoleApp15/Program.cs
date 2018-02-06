using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(' ');
            int n = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < n; i++)
            {
                string command = Console.ReadLine();
                
                switch (command)
                {
                    case "reverse":
                        Array.Reverse(arr);
                        
                        break;
                    case "distinct":     
                        arr = arr.Distinct().ToArray();
                       // Console.WriteLine(arr);
                        break;
                    case "replace":
                        string[] commandArgs = Console.ReadLine().Split(' ');
                        var index = int.Parse(commandArgs[1]);
                        var newString = commandArgs[2];
                        if (index > 0 && index < arr.Length)
                        {
                            Console.WriteLine("Invalid input!");
                        }
                            arr[index] = newString;
                        
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine(string.Join(", ", arr));
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] word = Console.ReadLine().ToCharArray();
            for (int i = 0; i < word.Length; i++)
            {
                Console.WriteLine($" {word[i]} -> {word[i] - 'a'} ");
            }
        }
    }
}

﻿using System;

namespace _07RepeatString
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            
            Console.WriteLine(RepeatString(input, n));
        }

        private static string RepeatString(string input, int n)
        {
            string result = "";
            for (int i = 0; i < n; i++)
            {
                result += input;
            }

            return result;
        }
    }
}

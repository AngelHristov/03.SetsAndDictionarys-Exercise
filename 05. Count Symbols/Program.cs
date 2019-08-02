using System;
using System.Collections.Generic;

namespace _05._Count_Symbols
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            SortedDictionary<char, int> dictionary = new SortedDictionary<char, int>();

            for (int i = 0; i < text.Length; i++)
            {
                if (!dictionary.ContainsKey(text[i]))
                {
                    dictionary[text[i]] = 0;
                }
                dictionary[text[i]]++;
            }
            foreach (var kvp in dictionary)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value} time/s");
            }
        }
    }
}
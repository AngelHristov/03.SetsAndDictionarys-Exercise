using System;
using System.Collections.Generic;

namespace _06._Wardrobe
{
    class Wardrobe
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var wardrobe = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < n; i++)
            {
                string[] line = Console.ReadLine().Split(" -> ");
                string colour = line[0];
                string[] clothes = line[1].Split(",");

                if (!wardrobe.ContainsKey(colour))
                {
                    wardrobe[colour] = new Dictionary<string, int>();
                }

                for (int j = 0; j < clothes.Length; j++)
                {
                    if (!wardrobe[colour].ContainsKey(clothes[j]))
                    {
                        wardrobe[colour][clothes[j]] = 0;
                    }
                    wardrobe[colour][clothes[j]]++;
                }
            }

            string[] search = Console.ReadLine().Split();

            foreach (var kvp in wardrobe)
            {
                Console.WriteLine($"{kvp.Key} clothes:");

                foreach (var item in kvp.Value)
                {
                    Console.Write($"* {item.Key} - {item.Value}");

                    if (kvp.Key == search[0] && item.Key == search[1])
                    {
                        Console.Write(" (found!)");
                    }

                    Console.WriteLine();
                }
            }
        }
    }
}

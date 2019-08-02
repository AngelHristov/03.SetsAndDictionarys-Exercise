﻿using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Dictionary<int, int> numbers = new Dictionary<int, int>();

        for (int i = 0; i < n; i++)
        {
            int num = int.Parse(Console.ReadLine());
            if (!numbers.ContainsKey(num))
            {
                numbers[num] = 0;
            }
            numbers[num]++;
        }
        foreach (var kvp in numbers)
        {
            if (kvp.Value % 2 == 0)
            {
                Console.WriteLine(kvp.Key);
            }
        }
    }
}
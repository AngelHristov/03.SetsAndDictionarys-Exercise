using System;
using System.Collections.Generic;

class Periodic
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        SortedSet<string> periodicSet = new SortedSet<string>();

        for (int i = 0; i < n; i++)
        {
            string[] line = Console.ReadLine().Split();
            for (int j = 0; j < line.Length; j++)
            {
                periodicSet.Add(line[j]);
            }
        }
        Console.WriteLine(string.Join(" ", periodicSet));
    }
}
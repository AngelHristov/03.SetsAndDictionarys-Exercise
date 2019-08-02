using System;
using System.Collections.Generic;
using System.Linq;

class Sets
{
    static void Main()
    {

        int[] n = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();

        HashSet<int> set1 = new HashSet<int>();
        HashSet<int> set2 = new HashSet<int>();

        SetElements(set1, n[0]);
        SetElements(set2, n[1]);

        set1.IntersectWith(set2);

        Console.WriteLine(string.Join(" ", set1));
    }

    private static void SetElements(HashSet<int> set, int n)
    {
        for (int i = 0; i < n; i++)
        {
            int num = int.Parse(Console.ReadLine());
            set.Add(num);
        }
    }
}
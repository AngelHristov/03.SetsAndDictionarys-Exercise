using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string line = string.Empty;
        Dictionary<string, HashSet<string>> follower = new Dictionary<string, HashSet<string>>();
        Dictionary<string, HashSet<string>> following = new Dictionary<string, HashSet<string>>();

        while ((line = Console.ReadLine()) != "Statistics")
        {
            string[] command = line.Split();
            string nameLogger = command[0];

            if (command[1] == "joined")
            {
                if (!follower.ContainsKey(nameLogger))
                {
                    follower[nameLogger] = new HashSet<string>();
                    following[nameLogger] = new HashSet<string>();
                }
            }
            else if (command[1] == "followed" && nameLogger != command[2] &&
                follower.ContainsKey(nameLogger) && follower.ContainsKey(command[2]))
            {
                follower[command[2]].Add(nameLogger);
                following[nameLogger].Add(command[2]);
            }

        }
        Console.WriteLine($"The V-Logger has a total of {follower.Count} vloggers in its logs.");
    }
}


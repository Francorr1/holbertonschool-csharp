using System;
using System.Collections.Generic;
using System.Linq;

class Dictionary
{
    public static void PrintSorted(Dictionary<string, string> myDict)
    {
        var listcast = myDict.Keys.ToList();
        listcast.Sort();
        foreach (var key in listcast)
        {
            Console.WriteLine("{0}: {1}", key, myDict[key]);
        }
    }
}
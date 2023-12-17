using System;
using System.Collections.Generic;

class List
{
    public static List<int> CommonElements(List<int> list1, List<int> list2)
    {
        HashSet<int> hash1 = new HashSet<int>(list1);
        HashSet<int> hash2 = new HashSet<int>(list2);
        hash1.IntersectWith(hash2);
        List<int> common = new List<int>();
        foreach (var item in hash1)
        {
            common.Add(item);
        }
        return common;
    }
}
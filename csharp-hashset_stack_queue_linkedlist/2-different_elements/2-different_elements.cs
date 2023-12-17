using System;
using System.Collections.Generic;

class List
{
    public static List<int> DifferentElements(List<int> list1, List<int> list2)
    {
        List<int> newList1 = list1.FindAll(item => !list2.Contains(item));
        List<int> newList2 = list2.FindAll(item => !list1.Contains(item));
        newList1.AddRange(newList2);
        newList1.Sort();
        return newList1;
    }
}
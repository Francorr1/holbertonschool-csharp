using System;
using System.Collections.Generic;
using System.Linq;

class List
{
    public static int Sum(List<int> myList)
    {
        var singlesList = myList.Distinct().ToList();
        int res = 0;
        for (int i = 0; i < singlesList.Count; i++)
        {
            res += singlesList[i];
        }
        return res;
    }
}
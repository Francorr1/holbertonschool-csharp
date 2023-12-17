using System;
using System.Collections.Generic;

class LList
{
    public static int Sum(LinkedList<int> myLList)
    {
        int res = 0;
        foreach (var item in myLList)
        {
            res += item;
        }
        return res;
    }
}
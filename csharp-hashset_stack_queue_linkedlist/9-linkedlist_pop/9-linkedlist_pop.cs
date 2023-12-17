using System;
using System.Collections.Generic;

class LList
{
    public static int Pop(LinkedList<int> myLList)
    {
        try
        {
            int FirstValue = myLList.First.Value;
            myLList.RemoveFirst();
            return FirstValue;
        }
        catch (System.Exception)
        {
            return 0;
            throw;
        }
    }
}
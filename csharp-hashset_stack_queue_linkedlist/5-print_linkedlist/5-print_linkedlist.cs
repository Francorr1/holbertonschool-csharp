using System;
using System.Collections.Generic;

class LList
{
    public static LinkedList<int> CreatePrint(int size)
    {
        LinkedList<int> LList = new LinkedList<int>();
        if (size < 0)
        {
            return LList;
        }
        else
        {
            for (int i = 0; i < size; i++)
            {
                LList.AddLast(i);
                Console.WriteLine("{0}", i);
            }
            return LList;
        }
    }
}
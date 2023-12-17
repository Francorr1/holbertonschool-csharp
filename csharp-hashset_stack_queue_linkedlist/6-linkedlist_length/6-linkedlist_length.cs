using System;
using System.Collections.Generic;

class LList
{
    public static int Length(LinkedList<int> myLList)
    {
        int cont = 0;
        foreach (var item in myLList)
        {
            cont++;
        }
        return cont;
    }
}
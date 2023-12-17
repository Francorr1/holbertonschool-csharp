using System;
using System.Collections.Generic;

class LList
{
    public static int GetNode(LinkedList<int> myLList, int n)
    {
        int cont = 0;
        foreach (var item in myLList)
        {
            if (cont == n)
            {
                return item;
            }
            cont++;
        }
        return 0;
    }
}
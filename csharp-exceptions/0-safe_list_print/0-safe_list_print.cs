using System;
using System.Collections.Generic;

class List
{
    public static int SafePrint(List<int> myList, int n)
    {
        int cont = 0;
        try
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(myList[i]);
                cont++;
            }
            return cont;
        }
        catch (System.Exception)
        {
            return cont;
            throw;
        }
    }
}
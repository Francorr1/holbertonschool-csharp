using System;
using System.Collections.Generic;

class List
{
    public static List<int> Divide(List<int> list1, List<int> list2, int listLength)
    {
        int a = 0;
        int b = 0;
        int res = 0;
        List<int> newList = new List<int>();
        for (int i = 0; i < listLength; i++)
        {
            res = 0;
            try
            {
                a = list1[i];
                b = list2[i];
            }
            catch (System.Exception)
            {
                Console.WriteLine("Out of range");
                return newList;
            }
            try
            {
                res = a / b;
            }
            catch (System.Exception)
            {
                Console.WriteLine("Cannot divide by zero");
            }
            newList.Add(res);
        }
        return newList;
    }
}
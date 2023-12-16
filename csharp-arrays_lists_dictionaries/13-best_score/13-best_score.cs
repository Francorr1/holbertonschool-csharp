using System;
using System.Collections.Generic;
using System.Linq;

class Dictionary
{
    public static string BestScore(Dictionary<string, int> myList)
    {
        try
        {
            var maxValue = myList.Aggregate((x, y) => x.Value > y.Value ? x : y).Key;
            return maxValue;
        }
        catch (System.Exception)
        {
            return "None";
            throw;
        }
    }
}
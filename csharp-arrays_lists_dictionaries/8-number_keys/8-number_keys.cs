﻿using System;
using System.Collections.Generic;
using System.Linq;

class Dictionary
{
    public static int NumberOfKeys(Dictionary<string, string> myDict)
    {
        int keys = 0;
        foreach (var key in myDict.Keys)
        {
            keys++;
        }
        return keys;
    }
}
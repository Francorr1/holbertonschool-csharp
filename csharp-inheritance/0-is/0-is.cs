using System;
using System.Collections.Generic;

/// <summary>
/// Class Obj
/// </summary>
class Obj
{
    /// <summary>
    /// Returns true if obj is an int, otherwise false
    /// </summary>
    public static bool IsOfTypeInt(object obj)
    {
        if (obj is int)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
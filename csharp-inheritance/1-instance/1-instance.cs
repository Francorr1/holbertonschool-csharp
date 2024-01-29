using System;
using System.Collections.Generic;

/// <summary>
/// Class object
/// </summary>
class Obj
{
    /// <summary>
    /// method that returns True if the object is an
    /// instance of, or if the object is an instance of a class
    /// that inherited from, Array, otherwise return False
    /// </summary>
    public static bool IsInstanceOfArray(object obj)
    {
        if (typeof(Array).IsAssignableFrom(obj.GetType()))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
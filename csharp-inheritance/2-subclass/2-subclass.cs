using System;
using System.Collections.Generic;

/// <summary>
/// Class Obj
/// </summary>
class Obj
{
    /// <summary>
    /// Returns true only if the derived type is a subclass of baseType, otherwise false
    /// </summary>
    public static bool IsOnlyASubclass(Type derivedType, Type baseType)
    {
        if (derivedType.IsSubclassOf(baseType))
        {
            if (derivedType != baseType)
            {
                return true;
            }
        }
        return false;
    }
}
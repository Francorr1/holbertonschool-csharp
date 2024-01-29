using System;
using System.Collections.Generic;
using System.Reflection;

/// <summary>
/// Class obj
/// </summary>
class Obj
{
    /// <summary>
    /// Method that prints the names of the available properties and methods of an object
    /// </summary>
    public static void Print(object myObj)
    {
        var type = myObj.GetType();
        Console.WriteLine("{0} Properties:", type.Name);
        foreach (PropertyInfo prop in type.GetProperties())
        {
            Console.WriteLine(prop.Name);
        }
        Console.WriteLine("{0} Methods:", type.Name);
        foreach (MethodInfo method in type.GetMethods())
        {
            Console.WriteLine(method.Name);
        }
    }
}
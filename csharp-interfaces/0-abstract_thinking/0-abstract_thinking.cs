using System;

/// <summary>
/// Base class
/// </summary>
abstract class Base
{
    public string name { get; set; }

    /// <summary>
    /// ToString() override
    /// </summary>
    /// <returns> New format </returns>
    public override string ToString()
    {
        return ($"{this.name} is a {this.GetType()}");
    }
}
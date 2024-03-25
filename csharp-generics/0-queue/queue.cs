using System;

/// <summary>
/// Queue class
/// </summary>
/// <typeparam name="T">Representation of a queue</typeparam>
class Queue<T>
{
    /// <summary>
    /// Returns the type of the Queue T
    /// </summary>
    public Type CheckType()
    {
        return typeof(T);
    }
}
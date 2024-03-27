using System;

/// <summary>
/// Base class
/// </summary>
public abstract class Base
{
    /// <summary>
    /// name property
    /// </summary>
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

/// <summary>
/// Interactive interface
/// </summary>
public interface IInteractive
{
    /// <summary>
    /// Interact method
    /// </summary>
    void Interact();
}

/// <summary>
/// Breakable interface
/// </summary>
public interface IBreakable
{
    /// <summary>
    /// durability property
    /// </summary>
    int durability { get; set; }

    /// <summary>
    /// Break method
    /// </summary>
    void Break();
}

/// <summary>
/// Collectable interface
/// </summary>
public interface ICollectable
{
    /// <summary>
    /// iscollected property
    /// </summary>
    bool isCollected { get; set; }

    /// <summary>
    /// Collect method
    /// </summary>
    void Collect();
}

/// <summary>
/// Door class
/// </summary>
public class Door : Base, IInteractive
{
    /// <summary>
    /// Door constructor
    /// </summary>
    /// <param name="name"> Default name: Door </param>
    public Door(string name="Door")
    {
        this.name = name;
    }

    /// <summary>
    /// Interact method
    /// </summary>
    public void Interact()
    {
        Console.WriteLine($"You try to open the {this.name}. It's locked.");
    }
}
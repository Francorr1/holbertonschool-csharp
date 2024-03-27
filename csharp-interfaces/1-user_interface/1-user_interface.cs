using System;

/// <summary>
/// Base class
/// </summary>
public abstract class Base
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
    bool isCollected { get; set; }

    /// <summary>
    /// Collect method
    /// </summary>
    void Collect();
}

/// <summary>
/// TestObject class
/// </summary>
public class TestObject : Base, IInteractive, IBreakable, ICollectable
{
    public int durability { get; set; }

    public bool isCollected { get; set; }

    public void Interact()
    {

    }

    public void Collect()
    {

    }

    public void Break()
    {

    }
}
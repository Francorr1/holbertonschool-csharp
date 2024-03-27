using System;

/// <summary>
/// Base class
/// </summary>
public abstract class Base
{
    /// <summary>
    /// name property
    /// </summary>
    string name { get; set; }

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
/// TestObject class
/// </summary>
public class TestObject : Base, IInteractive, IBreakable, ICollectable
{
    /// <summary>
    /// durability property
    /// </summary>
    public int durability { get; set; }

    /// <summary>
    /// isCollected property
    /// </summary>
    public bool isCollected { get; set; }

    /// <summary>
    /// name property
    /// </summary>
    public string name { get; set; }

    /// <summary>
    /// interact method
    /// </summary>
    public void Interact()
    {

    }

    /// <summary>
    /// break method
    /// </summary>
    public void Break()
    {

    }

    /// <summary>
    /// collect method
    /// </summary>
    public void Collect()
    {

    }
}
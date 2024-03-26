using System;

/// <summary>
/// Queue class
/// </summary>
/// <typeparam name="T">Representation of a queue</typeparam>
class Queue<T>
{
    public Node head { get; set; }
    public Node tail { get; set; }
    public int count;

    /// <summary>
    /// Returns the type of the Queue T
    /// </summary>
    public Type CheckType()
    {
        return typeof(T);
    }

    /// <summary>
    /// Class Node
    /// </summary>
    public class Node
    {
        public T value { get; set; }
        public Node next { get; set; }

        public Node(T value)
        {
            this.value = value;
            this.next = null;
        }
    }

    /// <summary>
    /// Method that creates a new Node and adds it to the queue
    /// </summary>
    public void Enqueue(T element)
    {
        Node node = new Node(element);
        node.value = element;

        if (head == null)
        {
            node.next = null;
            head = node;
            tail = node;
        }
        else
        {
            tail.next = node;
            tail = node;
        }
        count += 1;
    }

    /// <summary>
    /// Method that returns count
    /// </summary>
    /// <returns> count </returns>
    public int Count()
    {
        return count;
    }
}
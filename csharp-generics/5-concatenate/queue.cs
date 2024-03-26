using System;
using System.Text;

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

    /// <summary>
    /// Gets rid of the first node of the queue
    /// </summary>
    /// <returns> The deleted node </returns>
    public T Dequeue()
    {
        if (head == null && tail == null)
        {
            Console.WriteLine("Queue is empty");
            return default(T);
        }
        Node node = head;
        T fValue;
        if (node.next == null)
        {
            fValue = node.value;
            count -= 1;
            head = null;
            tail = null;
        }
        else
        {
            while (node.next != tail)
            {
                node = node.next;
            }
            fValue = tail.value;
            count -= 1;
            tail = node;
            node.next = null;
        }
        return fValue;
    }

    /// <summary>
    /// Peeks into the queue
    /// </summary>
    public T Peek()
    {
        if (head == null && tail == null)
        {
            Console.WriteLine("Queue is empty");
            return default(T);
        }
        else
        {
            return tail.value;
        }
    }

    /// <summary>
    /// Prints a queue
    /// </summary>
    public void Print()
    {
        if (head == null && tail == null)
        {
            Console.WriteLine("Queue is empty");
        }
        else
        {
            Node node = head;
            while (node != null)
            {
                Console.WriteLine(node.value);
                node = node.next;
            }
        }
    }

    public string Concatenate()
    {
        if (head == null && tail == null)
        {
            Console.WriteLine("Queue is empty");
            return null;
        }
        Type queueType = CheckType();
        if (queueType != typeof(string) && queueType != typeof(char))
        {
            Console.WriteLine("Concatenate() is for a queue of Strings or Chars only.");
            return null;
        }
        else
        {
            StringBuilder sb = new StringBuilder();
            Node node = head;
            while (node != null)
            {
                sb.Append(node.value);
                node = node.next;
            }
            return sb.ToString();
        }
    }
}
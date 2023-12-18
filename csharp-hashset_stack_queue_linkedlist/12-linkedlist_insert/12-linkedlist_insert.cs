using System;
using System.Collections.Generic;

class LList
{
    public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
    {
        LinkedListNode<int> current = myLList.First;
        if (current.Value > n)
        {
            myLList.AddFirst(n);
            current = myLList.First;
            return current;
        }
        while (current != null)
        {
            if (n < current.Value)
            {
                LinkedListNode<int> newnode = myLList.AddBefore(current, n);
                return newnode;
            }
            current = current.Next;
        }
        current = myLList.AddLast(n);
        return current;
    }
}
﻿namespace HashTable;

public class CustomHashTable<T>
{
    private class Node
    {
        public T Data;
        public Node Next;

        public Node(T data)
        {
            Data = data;
        }
    }

    private Node[] Names;

    public CustomHashTable(int size)
    {
        Names = new Node[size];
    }

    public void Add(T data) 
    {
        Node newNode = new Node(data);
        int arrayIndex = Math.Abs(data.GetHashCode()) % Names.Length;
        newNode.Next = Names[arrayIndex];
        Names[arrayIndex] = newNode;
    }

    public void Display()
    {
        for (int index = 0; index < Names.Length; index++)
        {
            Node tempNode = Names[index];

            Console.Write($"Index {index} : ");
            while(tempNode != null)
            {
                Console.Write(tempNode.Data + " -> ");
                tempNode = tempNode.Next;
            }
            Console.WriteLine();
        }
    }

    public void Search(T data)
    {
        int arrayIndex = Math.Abs(data.GetHashCode()) % Names.Length;
        Node tempNode = Names[arrayIndex];
        if (tempNode == null) 
        {
            Console.WriteLine($"{data} not found");
            return;
        }

        while(!tempNode.Data.Equals(data)) 
        {
            if (tempNode.Next == null)
            {
                Console.WriteLine($"{data} not found");
                return;
            }
            tempNode = tempNode.Next;
        }

        Console.WriteLine($"{data} is present at {arrayIndex} index in the Hash Table");
    }

    public void Delete(T data)
    {
        int arrayIndex = Math.Abs(data.GetHashCode()) %Names.Length;
        Node tempNode = Names[arrayIndex];

        if (tempNode == null)
        {
            Console.WriteLine($"{data} not found in Hash Table");
            return;
        }

        if (tempNode.Data.Equals(data))
        {
            Names[arrayIndex] = tempNode.Next;
            return;
        }

        if (tempNode.Next == null)
        {
            Console.WriteLine($"{data} not found in Hash Table");
            return;
        }

        while (!tempNode.Next.Data.Equals(data))
        {
            if (tempNode.Next.Next == null)
            {
                Console.WriteLine($"{data} not found");
                return;
            }
            tempNode = tempNode.Next;
        }
        tempNode.Next = tempNode.Next.Next;
    }
}

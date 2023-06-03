namespace HashTable;

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
        Names[arrayIndex] = newNode;
    }
}

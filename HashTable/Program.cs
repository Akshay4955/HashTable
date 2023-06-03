namespace HashTable;
internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Hash Table...!!!");
        CustomHashTable<string> myHashTable = new CustomHashTable<string>(10);
        myHashTable.Add("Akshay");
        myHashTable.Add("Rupesh");
        myHashTable.Add("Rahul");
        myHashTable.Add("Mangesh");
        myHashTable.Add("Vishal");

        myHashTable.Display();
    }
}
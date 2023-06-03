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
        myHashTable.Add("Nadim");
        myHashTable.Add("Shree");
        myHashTable.Add("Siddharth");
        myHashTable.Add("Tanaji");
        myHashTable.Add("Vaibhav");
        myHashTable.Add("Yogesh");
        myHashTable.Add("Ramesh");
        myHashTable.Add("Rushikesh");
        myHashTable.Add("Sajjan");

        myHashTable.Display();

        myHashTable.Search("Rupesh");
        myHashTable.Search("AnyName");

        myHashTable.Delete("Yogesh");
        myHashTable.Delete("Rutvik");
        myHashTable.Display();
    }
}
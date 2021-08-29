namespace HashTable 
{
    public class Program
    {
        public static void Main(string[] args)
        {
            HashTable h = new HashTable(2);
            h.Set("bananas", 42);
            h.Set("avocados", 11);
            Console.WriteLine(h.Get("avocados"));
            h.Keys();

           

        }
    }
}
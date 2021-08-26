// See https://aka.ms/new-console-template for more information
namespace ArrayImplementation 
{
    public class Program
    {
        public static void Main(string[] args)
        {
            MyArray myArray = new MyArray();

            myArray.Push("Hello");
            myArray.Push("World");
            myArray.Push("!");

            //myArray.delete(1);

            for (int i = 0; i < myArray.length; i++)
            {
                Console.WriteLine(myArray.Get(i));
            }
        }
    }
}
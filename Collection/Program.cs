using System.Collections;

namespace Collection
{
    internal class Program
    {
       public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the collection program");
            //Adding the arraylist element
            ArrayList myList = new ArrayList();
            myList.Add(10);
            myList.Add(20);
            myList.Add(30);
            myList.Add(40);
            Console.WriteLine(myList.Capacity);
            myList.Add(60);
            myList.Add(70);
            //Shows the capacity
            Console.WriteLine(myList.Capacity);
            foreach(int i in myList)
            {
                Console.WriteLine(i);
            }
            //Insert the element
            myList.Insert(2, 25);
            myList.Insert(3, 39);
            foreach (int i in myList)
            {
                Console.WriteLine(i);
            }
            //remove element
            myList.Remove(40);
            myList.RemoveAt(5);
            foreach(int i in myList)
            {
                Console.WriteLine(i);
            }


        }
    }
}
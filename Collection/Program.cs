namespace Collection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the collection program");
            List<string> list = new List<string>();
            //Adding the elements in list
            list.Add("Apple)");
            list.Add("Mango");
            list.Add("Orange");
            //Print the element by using for loop
            for(int i = 0; i<list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
            
            //using foreach loop
            foreach(string o in list)
            {
                Console.WriteLine(o);
            }
            //Adding items
            list.Insert(0, "Banana");
            list[0] = "Tomato";
            foreach(string o in list)
            {
                Console.WriteLine(o);

            }
            // Removing the items
            list.Remove("Mango");
            //Checking the element in the list having or not
            Console.WriteLine("Enter the element proper name ");
            string name = Console.ReadLine();
            if (list.Contains(name))
            {
                Console.WriteLine("Sucess");
            }
            else
            {
                Console.WriteLine("Failure");
            }
            foreach(string o in list)
            {
                Console.WriteLine(o);
            }

           
        }
    }
}
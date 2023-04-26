namespace Collection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the collection program");
            Dictionary<int ,string> student = new Dictionary<int ,string>();
            //Adding the element in Dictionary
            student.Add(1, "Aman");
            student.Add(2, "Mohan");
            student.Add(3, "Rohan");
            student.Add(4, "Sohan");
            
            foreach(KeyValuePair<int,string> kv in student)
            {
                Console.WriteLine(kv.Key + " " + kv.Value);
            }
            //Find the student entry
            Console.WriteLine("Enter the Key to search for Names");
            int i = Convert.ToInt32(Console.ReadLine());
            if (student.ContainsKey(i))
            {
                Console.WriteLine("Student name found is: "+ student[i]);
            }
            else
            {
                Console.WriteLine("Student entry not found");
            }
            //Remove element
            student.Remove(i);
            Console.WriteLine("After removing the entry");
            foreach(KeyValuePair<int,string> kv in student)
            {
                Console.WriteLine(kv.Key + " " + kv.Value);
            }



        }
    }
}
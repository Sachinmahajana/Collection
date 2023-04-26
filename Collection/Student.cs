using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{

    public class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public long PhoneNumber { get; set; }
        public string Address { get; set; }

        public static void StudentDataManipulation()
        {
            List<Student> students = new List<Student>()
            {
                new Student() { StudentId =3,StudentName= "Ratan",PhoneNumber= 9874647456,Address="Mumbai" },
                new Student() { StudentId=4,StudentName = "Rony",PhoneNumber=9745464748,Address="Pune" },
                new Student() {StudentId=5,StudentName = "Santosh",PhoneNumber=9876567666,Address="Banglore" },
                new Student() {StudentId=6, StudentName = "Renuka",PhoneNumber=9874567484,Address="Delhi" },
            };
            foreach (Student student in students)
            {
                Console.WriteLine("Id:{0} Name:{1} PhoneNumber:{2} Address:{3}", student.StudentId, student.StudentName, student.PhoneNumber, student.Address);
            }

            Console.WriteLine("Please enter student name to delete from collection");
            string name = Console.ReadLine();
            bool isPresent = false;
            foreach (Student student in students)
            {
                if (student.StudentName.Equals(name))
                {
                    Console.WriteLine("Student is present so removing");
                    students.Remove(student);
                    isPresent = true;
                    Console.WriteLine("After remove operation");
                    break;
                }
            }
            if (!isPresent)
            {
                Console.WriteLine("Student not exist please provide proper name");
            }
            foreach (Student student in students)
            {
                Console.WriteLine("Id:{0} Name:{1} PhoneNumber:{2} Address:{3}", student.StudentId, student.StudentName, student.PhoneNumber, student.Address);
            }     
        }
        public static void StudentUpdateDetails(List<Student> List)
        {
            Console.WriteLine(".............................................");
            Console.WriteLine("Please specify which student to update");
            string name = Console.ReadLine();
            bool isPresent = false;
            foreach(Student s in List)  
            {
                if (s.StudentName.Equals(name))
                {
                    isPresent = true;
                    Console.WriteLine("Id:{0} Name:{1} PhoneNumber:{2} Address:{3}", s.StudentId, s.StudentName, s.PhoneNumber, s.Address);
                    Console.WriteLine("Please select which details you want to update");
                    Console.WriteLine("1.StudentId\n2.Phone\n3.Address");
                    int option = Convert.ToInt32(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            Console.WriteLine("Please enter StudentId");
                            s.StudentId = Convert.ToInt32(Console.ReadLine());
                            break;
                        case 2:
                            Console.WriteLine("Please enter Phonenumber");
                            s.PhoneNumber = Convert.ToInt32(Console.ReadLine());
                            break;
                        case 3:
                            Console.WriteLine("Please enter Address");
                            s.Address = Console.ReadLine();
                            break;
                    }
                    Console.WriteLine("After Update");
                    Console.WriteLine("Id:{0} Name:{1} PhoneNumber:{2} Address{3}", s.StudentId, s.StudentName, s.PhoneNumber, s.Address);

                }
            }
            if (!isPresent)
            {
                Console.WriteLine("Student is not exist");
            }

        }
        

        }
    } 

using System;
using static CS_7._2.Student;

namespace CS_7._2
{
    partial class Person
    {
       public partial string Eat();
    }


    partial class Person
    {
        public partial string Eat()
        {
            Console.WriteLine("Eat 2");
            return "2";
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            // PartialClass();

            Person person = new Person();
            Console.WriteLine(person.Eat());
        }



        private static void PartialClass()
        {
            Student s = new Student { Age = 25, Name = "Eli", Surname = "Eliyev" };
            Console.WriteLine(s.Age);
            Console.WriteLine(s.Name);
            Console.WriteLine(s.Surname);

            Address address = new Address();
            Student.Address address2 = new Student.Address { };
        }
    }
}

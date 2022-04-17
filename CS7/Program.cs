using System;
using Outer.Inner;

namespace Outer
{
    namespace Inner
    {
        class Person
        {
            public int Property { get; set; }
        }
    }
}


namespace CS_7
{
    public class Program
    {
        static void Main()
        {
            // Outer.Inner.Person person = new Outer.Inner.Person { Property = 50 };
            Person person = new Person { Property = 50 };
            Console.WriteLine(person.Property);
        }
    }
}
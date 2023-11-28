using System;

namespace RemainingThings
{
    struct Person
    {
        public string Name;
        public int Age;
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.Name = "James";
            p.Age = 40;
            Modify(p);
            Console.WriteLine($"{p.Name} is {p.Age}");
        }

        public static void Modify(Person person)
        {
            person.Name = "Bond";
            person.Age = 50;
        }
    }
}

using System;

namespace BasicsOfOOP
{
    public class Student
    {
        private string _name;
        private string _lastName;
        private int _age;
        public Student(string name, string lastName, int age)
        {
            _name = name;
            _lastName = lastName;
            _age = age;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var s = new Student("James", "Bond" ,20);
            Console.WriteLine($"Student {s.name} {s.lastName} is {s.age}");
        }
    }
}

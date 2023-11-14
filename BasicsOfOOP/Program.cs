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
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentNullException("Name cannot be empty");

            if (string.IsNullOrWhiteSpace(lastName))
                throw new ArgumentNullException("LastName cannot be empty");

            if (age < 15)
                throw new ArgumentException("Age should be at least 15");

            _name = name;
            _lastName = lastName;
            _age = age;
        }

        public string Name
        {
            get => _name;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentNullException("Name cannot be empty");
                _name = value;
            }
        }

        public string LastName => _lastName;

        public int Age => _age;


        //public string GetName()
        //{
        //    return _name;
        //}
        //public string GetLastName()
        //{
        //    return _lastName;
        //}
        //public int GetAge()
        //{
        //    return _age;
        //}

        //public void SetName(string newName)
        //{
        //    if (string.IsNullOrWhiteSpace(newName))
        //        throw new ArgumentNullException("Name cannot be empty");
        //    _name = newName;
        //}
    }

    class Program
    {
        static void Main(string[] args)
        {
            var s = new Student("James", "Bond", 20);
            Console.WriteLine($"Student {s.Name} {s.LastName} is {s.Age}");

            s.Name = " ";
            Console.WriteLine($"Student {s.Name} {s.LastName} is {s.Age}");
        }
    }
}

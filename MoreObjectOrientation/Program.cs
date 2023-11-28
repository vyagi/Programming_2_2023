using System;

namespace MoreObjectOrientation
{
    interface ILivingCreature
    {
        public void Die();
    }

    abstract class Animal
    {
        public abstract void MakeSound();
    }

    class Dog : Animal, ILivingCreature
    {
        public override void MakeSound() => Console.WriteLine("Hau hau");
        
        public void Die() => Console.WriteLine("Oh what a sorrow. A dog died....");
    }

    class Cat : Animal
    {
        public override void MakeSound() => Console.WriteLine("Miau miau");
    }

    class Monkey : Animal 
    {
        public override void MakeSound() => Console.WriteLine("Uuaa");
    }

    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.MakeSound();

            Cat cat = new Cat();
            cat.MakeSound();

            Animal[] animals = { dog, cat, new Dog(), new Cat(), new Monkey() };
            MakeNoises(animals);

            Kill(new[] { dog, new Dog() });
        }

        public static void MakeNoises(Animal[] animals)
        {
            foreach (Animal animal in animals)
            {
                animal.MakeSound();
            }
        }

        public static void Kill(ILivingCreature[] livingCreatures)
        {
            foreach (ILivingCreature livingCreature in livingCreatures)
            {
                livingCreature.Die();
            }
        }
    }
}

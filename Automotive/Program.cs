using System;

namespace Automotive
{
    public class Car
    {
        private readonly string _brand;
        private readonly string _model;
        private readonly int _tankCapacity;
        private readonly double _fuelConsumption;
        private double _fuelLevel;
        private double _odometer;
        public Car(string brand, string model, int tankCapacity, double fuelConsumption)
        {
            //HOMEWORK : ADD CHECKS
            _brand = brand;
            _model = model;
            _tankCapacity = tankCapacity;
            _fuelConsumption = fuelConsumption;
        }

        public void AddFuel(int amount)
        {
            //Homework - add checks
            _fuelLevel += amount;

            if (_fuelLevel > _tankCapacity) 
                _fuelLevel = _tankCapacity;
        }

        public void Drive(int distance)
        {
            //Homework - add checks
            var maximumDistance = 100 * _fuelLevel / _fuelConsumption;
            if (distance <= maximumDistance)
            {
                _odometer += distance;
                _fuelLevel -= distance / 100.0 * _fuelConsumption;
            }
            else
            {
                _odometer += maximumDistance;
                _fuelLevel = 0;
            }
        }

        public string BrandAndModel => $"{_brand} {_model}";

        public int FuelLevel => (int)_fuelLevel;

        public int Odometer => (int)_odometer;
    }


    class Program
    {
        static void Main(string[] args)
        {
            var c = new Car("Opel", "Insigina", 50, 5);
            c.AddFuel(30);
            c.AddFuel(30);

            Console.WriteLine($"{c.BrandAndModel} has {c.FuelLevel} liters and drove {c.Odometer}");

            c.Drive(50);
            Console.WriteLine($"{c.BrandAndModel} has {c.FuelLevel} liters and drove {c.Odometer}");

            c.Drive(100);
            Console.WriteLine($"{c.BrandAndModel} has {c.FuelLevel} liters and drove {c.Odometer}");

            c.Drive(-1000);
            Console.WriteLine($"{c.BrandAndModel} has {c.FuelLevel} liters and drove {c.Odometer}");

            //More homework: implement daily odometer with limit and reset button (method)
            //Implement limit to the global odomter
            
            //Design and implement CoffeeMachine class which will have:
            //water level   1l
            //coffee level  1g or 1kg (your decision)
            //Americano or Espresso
            //Implement grounds container with EmptyGrounds method

        }
    }
}

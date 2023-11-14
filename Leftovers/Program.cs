using System;
using System.Collections.Generic;

namespace Leftovers
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int>();

            for (var i = 0; i < 4; i++)
            {
                Console.WriteLine($"Enter number no: {i + 1}");
                list.Add(int.Parse(Console.ReadLine()));
            }

            var sum = 0;

            for (var i = 0; i < list.Count; i++)
                sum += list[i];

            var average = 1.0 * sum / list.Count;
            Console.WriteLine($"The sum is {sum} and the average is {average}");

            
            //var array = new int[4];

            //for (var i = 0; i < array.Length; i++)
            //{
            //    Console.WriteLine($"Enter number no: {i + 1}");
            //    array[i] = int.Parse(Console.ReadLine());
            //}

            //var sum = 0;

            //for (var i = 0; i < array.Length; i++)
            //    sum += array[i];

            //var average = 1.0 * sum / array.Length;
            //Console.WriteLine($"The sum is {sum} and the average is {average}");
        }
    }
}

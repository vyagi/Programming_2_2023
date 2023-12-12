using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicsOfLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            var heights = new int[] { 178, 182, 190, 181, 182, 178, 172, 175, 180, 181 };
            var names = new string[] { "James", "John", "Bob", "Kevin", "Gru", "Fred", "Mr. Bean" };
            //var max = heights.Max();

            //Console.WriteLine(max);
            //Console.WriteLine(heights.Min());
            //Console.WriteLine(heights.Sum());
            //Console.WriteLine(heights.Average());

            var tallPeople = heights.Where(x => x > 180);

            foreach (var t in tallPeople)
            {
                Console.WriteLine(t);
            }
            Console.WriteLine("****************");

            var sorted = heights.OrderBy(x => x);
            foreach (var t in sorted)
            {
                Console.WriteLine(t);
            }
            Console.WriteLine("****************");

            var fromShortestToLongest = names
                .OrderBy(x => x.Length)
                .ThenBy(x => x);

            foreach (var t in fromShortestToLongest)
            {
                Console.WriteLine(t);
            }
            Console.WriteLine("****************");

            var myFancyThing = names
                .Where(x => x.Length > 3 && !x.Contains(" "))
                .OrderByDescending(x => x)
                .Select(x => x.ToLower());

            foreach (var t in myFancyThing)
            {
                Console.WriteLine(t);
            }
            Console.WriteLine("****************");


            //Confusing at first
            var grouped = names.GroupBy(x => x.Length);
            foreach (var t in grouped)
            {
                Console.WriteLine(t.Key + " " + t.Count());
                foreach (var item in t)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}

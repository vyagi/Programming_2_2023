using System;

namespace ExtensionMethods
{
    static class StringUtilities
    {
        public static string ToName(this string input) =>
            $"{input[0].ToString().ToUpper()}{input[1..].ToLower()}";
    }

    static class IntUtilities
    {
        public static bool IsOdd(this int input) => input % 2 == 1;
    }

    class Program
    {
        static void Main(string[] args)
        {
            string name = "marCIN"; //Marcin

            Console.WriteLine(name.ToName());

            Console.WriteLine(7.IsOdd());
            Console.WriteLine(8.IsOdd());
        }
    }
}

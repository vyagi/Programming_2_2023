using System;

namespace Generics
{
    class Pair<T1, T2>
    {
        public T1 First;
        public T2 Second;
    }

    class Program
    {
        static void Main(string[] args)
        {
            var pi = new Pair<int, int>();
            pi.First = 10;
            pi.Second = 20;

            var ps = new Pair<string, string>();
            ps.First = "James";
            ps.Second = "Bond";

            var pp = new Pair<DateTime, string>();
        }
    }
}

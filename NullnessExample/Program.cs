using System;

#nullable enable

namespace NullnessExample
{
    class Program
    {
        public void M(string? theString)
        {
            Console.WriteLine($"Length is {theString.Length}");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}

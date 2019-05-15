using System;

#nullable enable

namespace NullnessExample
{
    class Program
    {
        public void M(string? theString)
        {
            // In the project file, this warning code is suppressed, but the nowarn is ignored.
            Console.WriteLine($"Length is {theString.Length}");
        }
        static void Main(string[] args)
        {
            // Explicitly trigger a warning here, note that is gets suppressed
            while (false) { Console.Write(""); }

            Console.WriteLine("Hello World!");
        }
    }
}

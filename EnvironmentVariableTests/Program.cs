using System;

namespace EnvironmentVariableTests
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Before modification: {Environment.GetEnvironmentVariable("UPDATE")}");
            Environment.SetEnvironmentVariable("UPDATE", "123");
            Console.WriteLine($"After modification: {Environment.GetEnvironmentVariable("UPDATE")}");
            Console.ReadLine();
        }
    }
}

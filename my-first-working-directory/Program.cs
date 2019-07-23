namespace MyFirstWorkingDirectory
{
    using System;
    using System.IO;

    internal static class Program
    {
        private static void Main()
        {
            Console.WriteLine("Hello World!");

            string baseDirectory = AppContext.BaseDirectory;

            string currentDirectory = $"{Directory.GetCurrentDirectory()}\\";

            Console.WriteLine($"Current AppContext.BaseDirectory is {baseDirectory}");
            Console.WriteLine($"Current working directory is {currentDirectory}");
            Console.WriteLine($"Both are {(baseDirectory == currentDirectory ? "" : "not ")}the same");

            Console.ReadLine();
        }
    }
}
using System;
using System.Threading;

namespace DotNet6ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Program Execution started at {DateTime.Now}");
            Random rm = new Random();
            int seconds = rm.Next(2, 10);
            Thread.Sleep(seconds * 1000);
            Console.WriteLine($"Program Execution end at {DateTime.Now}");
        }
    }
}

using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string HelloWorldMessage = "Jupiter";

            Console.WriteLine(HelloWorld(HelloWorldMessage));
        }

        private static string HelloWorld(string message)
        {
            return "Hello " + message + "!";
        }
    }
}

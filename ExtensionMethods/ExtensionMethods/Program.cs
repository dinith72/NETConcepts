using System;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string sample = "sample string";

            sample.PrintToConsole();
        }
    }

    // simple extension to  the string class
    public static class Extensions
    {
        public static void PrintToConsole(this string message)
        {
            Console.WriteLine(message);

            ILoggerLibrary library = new LoggerLibrary();
            library.LogError("error occured in runnig");
        }
    }


    // extension to the logger library 
    public static class ExtesionLoggerLibrary
    {
        // extending the method of a class 
        //public static void LogError(this LoggerLibrary loggerLibrary , string message)
        //{
        //    var defcolour = Console.ForegroundColor;
        //    Console.ForegroundColor = ConsoleColor.Red;
        //    loggerLibrary.Log(message, "Error");
        //    Console.ForegroundColor = defcolour;
        //}
        
        // extending the method of the interface 
        public static void LogError(this ILoggerLibrary loggerLibrary , string message)
        {
            var defcolour = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            loggerLibrary.Log(message, "Error");
            Console.ForegroundColor = defcolour;
        }
    }
}

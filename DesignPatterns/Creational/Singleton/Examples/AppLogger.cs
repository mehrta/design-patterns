using System;

namespace MehrdadTajedini.DesignPatterns.Creational.Singleton.Examples
{
    public sealed class AppLogger
    {
        private static readonly AppLogger instance = new AppLogger();

        // Explicit static constructor to tell C# compiler
        // not to mark type as beforefieldinit
        static AppLogger()
        {
        }

        private AppLogger()
        {
        }

        public static AppLogger Instance
        {
            get
            {
                return instance;
            }
        }

        public void WriteLog(string title, string text, int code)
        {
            // Write the log to database or file.
            // Here, we just write the log into the Console.
            Console.WriteLine($"({DateTime.Now.ToShortTimeString()}) Log: {code} ==> {title}");
            Console.WriteLine($"{text}");
            Console.WriteLine("------");
        }

        public void ClearLogs()
        {
            Console.Clear();
        }
    }
}

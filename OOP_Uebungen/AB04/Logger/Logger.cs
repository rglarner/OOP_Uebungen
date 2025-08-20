using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    public class Logger
    {
        public enum LogLevel
        {
            Info,
            Warn,
            Error
        }
        public static void Log(string message, LogLevel level)
        {
            ConsoleColor original = Console.ForegroundColor;

            switch (level)
            {
                case LogLevel.Info:
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case LogLevel.Warn:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case LogLevel.Error:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
            }

            Console.WriteLine($"[{level}] {message}");
            Console.ForegroundColor = original; // Farbe zurücksetzen
        }
    }
}

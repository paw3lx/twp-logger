using System;
using TwpLogger;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var logger = new Logger("Main Logger"); 
            logger.Log(LogLevel.Error, "Jakis blad: {0} {1}", "glupi blad", "asdasd");
        }
    }
}

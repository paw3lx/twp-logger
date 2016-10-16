using System;
using TwpLogger;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var logger = new Logger("Main Logger"); 
            logger.Info("logging simple info message");
            logger.Warn("logging {0} message with parameters", "warn");
        }
    }
}

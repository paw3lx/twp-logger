using System;

namespace TwpLogger
{
    public class Logger
    {
        private string Name;


        public Logger()
        {
            Name = System.Guid.NewGuid().ToString();

        }

        public Logger(string name){
            Name = name;
        }


        public void Log(string message)
        {
            LogToConsole(LogLevel.Info, message);

        }

        public void Log(LogLevel level, string message)
        {
            LogToConsole(level, message);

        }

        public void Log(LogLevel level, string text, params string[] args)
        {
            LogToConsole(level, string.Format(text, args));
        }


        private void LogToConsole(LogLevel level, string message){
            Console.WriteLine(string.Format("{0} {1} [{2}]: {3}", DateTime.Now, Name, level, message));
        }


        
    }
}
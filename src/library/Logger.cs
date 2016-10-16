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

        public static Logger GetLogger(string name){
            return new Logger(name);
        }


        public void Log(string message)
        {
            LogToConsole(LogLevel.Info, message);

        }

        public void Log(LogLevel level, string text, params string[] args)
        {
            LogToConsole(level, string.Format(text, args));
        }

        public void Info(string message, params string[] args){
            Log(LogLevel.Info, message, args);

        }

        public void Warn(string message, params string[] args){
            Log(LogLevel.Warn, message, args);

        }

        public void Error(string message, params string[] args){
            Log(LogLevel.Error, message, args);

        }

        private void LogToConsole(LogLevel level, string message){
            Console.WriteLine(string.Format("{0} {1} [{2}]: {3}", DateTime.Now, Name, level, message));
        }


        
    }
}
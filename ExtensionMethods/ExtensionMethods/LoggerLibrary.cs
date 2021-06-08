using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    // simulation of a logger library imported from a 3rd party 
    public class LoggerLibrary : ILoggerLibrary
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }

        public void Log(string message, string messageType)
        {
            Log($" {message} : {messageType} .");
        }
    }
}

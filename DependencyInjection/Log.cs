using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    internal class Log : ILog
    {
        public void LogMess(string message) {

            Console.WriteLine($"Logging message : {message}");
        
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDExample
{
    class DatabaseLogger:ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine("Database message " + message);
        }
    }
}

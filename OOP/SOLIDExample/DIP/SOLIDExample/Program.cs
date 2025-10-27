using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var _application = new Application(new FileLogger());
            _application.Process();

            var _application2 = new Application(new DatabaseLogger());
            _application2.Process();
        }
    }
}

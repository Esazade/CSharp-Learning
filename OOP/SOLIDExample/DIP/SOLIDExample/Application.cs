using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDExample
{
    class Application
    {
        private ILogger _logger;

        public Application(ILogger logger)
        {
            _logger = logger; 
        }

        public void Process()
        {
            _logger.Log("Process completed");
        }
    }
}

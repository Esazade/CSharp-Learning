using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDExample
{
    class SimplePrinter:IPrintMachine
    {
        void Print()
        {
            Console.WriteLine("print")
        }
    }
}

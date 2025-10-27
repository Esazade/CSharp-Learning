using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP
{
    class Square:Shape
    {
        public int side { get; set; }

        public override int CalculateArea()
        {
            return side * side;
        }
    }
}

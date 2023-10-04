using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagramMaker
{
    public abstract class Shape
    {
        public Shape() { }

        //Abstract clases dont contain methods logic and must be implemented in children classes
        public abstract float Area();
        public abstract float Perimeter();
    }
}

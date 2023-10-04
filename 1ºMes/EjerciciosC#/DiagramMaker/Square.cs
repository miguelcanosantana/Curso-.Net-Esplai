using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagramMaker
{
    public class Square : Rectangle
    {
        //Using width width in the base
        public Square(float width) : base(width, width)
        {
            this.width = width;
        }
    }
}

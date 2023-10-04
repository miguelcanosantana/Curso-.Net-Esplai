using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagramMaker
{
    public class Rectangle : Polygon
    {
        public Rectangle(float width, float height) : base(width, height)
        {
            this.height = height;
            this.width = width;
        }

        public override float Area()
        {
            return width * height;
        }

        public override float Perimeter()
        {
            return width * 2 + height * 2;
        }
    }
}

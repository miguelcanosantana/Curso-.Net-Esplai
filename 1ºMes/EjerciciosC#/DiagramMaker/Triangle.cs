using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagramMaker
{
    public class Triangle : Polygon
    {
        public Triangle(float width, float height) : base(width, height)
        {
            this.width = width;
            this.height = height;
        }

        public override float Area()
        {
            return (1 / 2) * width * height;
        }

        public override float Perimeter()
        {
            return (float)Math.Sqrt(Math.Pow(this.width, 2) + Math.Pow(this.height, 2));
        }
    }
}

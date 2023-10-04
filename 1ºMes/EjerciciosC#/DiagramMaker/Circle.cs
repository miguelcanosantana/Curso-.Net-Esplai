using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagramMaker
{
    public class Circle : Shape
    {
        private float radius;

        public Circle(float radius)
        {
            this.radius = radius;
        }

        public override float Area()
        {
            return (float)(Math.PI * Math.Pow(radius, 2));
        }

        public override float Perimeter()
        {
            return (float)(2 * Math.PI * radius); ;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagramMaker
{
    public abstract class Polygon : Shape
    {
        protected float width;
        protected float height;

        public Polygon(float width, float height)
        {
            this.width = width;
            this.height = height;
        }
    }
}

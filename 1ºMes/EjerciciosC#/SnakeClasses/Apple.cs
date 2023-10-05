using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace SnakeClasses
{
    public class Apple
    {
        private Vector2 position;

        public Apple() 
        { 
        }

        public Vector2 GetPosition() { return position; }

        public void SetPosition(Vector2 position) { this.position = position; }
    }
}

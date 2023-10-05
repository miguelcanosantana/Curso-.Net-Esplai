using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace SnakeClasses
{
    public class Grid
    {
        private Vector2 size;
        public List<List<string>> boxList = new List<List<string>>();

        public Grid() 
        { 
        }

        public void SetSize(Vector2 size) { this.size = size; }

        public Vector2 GetSize() { return this.size; }

        public void ClearGrid()
        {
            boxList.Clear();
        }

    }
}

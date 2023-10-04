using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagramMaker
{
    public class Diagram
    {
        private List<Shape> shapesList;

        public Diagram()
        {
            shapesList = new List<Shape>();
        }

        public void AddShape(Shape shape)
        {

        }

        public void DisplayShapes()
        {
            for (int i = 0; i < shapesList.Count; i++)
            {
                Console.WriteLine(shapesList[i].GetType().Name);
            }
        }

    }
}

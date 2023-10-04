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
            shapesList.Add(shape);
        }

        public void DisplayShapes()
        {
            for (int i = 0; i < shapesList.Count; i++)
            {
                Console.WriteLine(shapesList[i].GetType().Name);

                if (i < shapesList.Count - 1)
                    Console.WriteLine("|");
            }
        }

        public void TotalArea()
        {
            float area = 0;

            foreach (Shape shape in shapesList)
            {
                area += shape.Area();
            }

            Console.WriteLine("\nTotal area is: " + area);
        }

    }
}

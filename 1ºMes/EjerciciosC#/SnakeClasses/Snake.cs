using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace SnakeClasses
{
    public class Snake
    {
        private List<Vector2> snakeParts = new List<Vector2>();
        private List<Vector2> previousPartsPositions = new List<Vector2>();
        private Vector2 inputDirection = Vector2.Zero;
        private ConsoleKey previousKey;
    }
}

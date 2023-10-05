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
        private List<Vector2> parts = new List<Vector2>();
        private List<Vector2> previousPartsPositions = new List<Vector2>();
        private Vector2 inputDirection = Vector2.Zero;
        private ConsoleKey previousKey;

        public Snake() 
        {
        }

        public List<Vector2> GetParts() { return parts; }

        public ConsoleKey GetPreviousKey() { return previousKey; }

        public void ClearParts() { parts.Clear(); }

        public void AddPart(Vector2 part) { parts.Add(part); }

        public void SetInputDirection(Vector2 inputDirection) { this.inputDirection = inputDirection; }

        public void SetPreviousKey(ConsoleKey previousKey) { this.previousKey = previousKey; }
    }
}

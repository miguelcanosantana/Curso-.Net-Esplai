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
        private List<Vector2> previousParts = new List<Vector2>();
        private Vector2 inputDirection = Vector2.Zero;
        private ConsoleKey previousKey;

        public Snake() 
        {
        }

        public List<Vector2> GetParts() { return parts; }

        public List<Vector2> GetPreviousParts() { return previousParts; }

        public ConsoleKey GetPreviousKey() { return previousKey; }

        public Vector2 GetInputDirection() { return inputDirection; }

        public void ClearParts() { parts.Clear(); }

        public void ClearPreviousParts() { previousParts.Clear(); }

        public void AddPart(Vector2 part) { parts.Add(part); }

        public void AddPreviousPart(Vector2 part) { previousParts.Add(part); }

        public void SetSnakePartToPreviousPosition(Vector2 part, Vector2 previousPosition) { part = previousPosition; }

        public void SetInputDirection(Vector2 inputDirection) { this.inputDirection = inputDirection; }

        public void SetPreviousKey(ConsoleKey previousKey) { this.previousKey = previousKey; }
    }
}

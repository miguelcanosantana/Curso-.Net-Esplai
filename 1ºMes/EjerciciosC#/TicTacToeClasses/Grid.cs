using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeClasses
{
    public class Grid
    {
        public string[,] boxes = new string[3, 3]{
                    {".", ".", "."},
                    {".", ".", "."},
                    {".", ".", "."},
        };

        public Grid() { }
    }
}

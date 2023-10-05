using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeClasses
{
    public class Grid
    {
        private int Length { get; set; }
        private int Width { get; set; }
        private List<List<string>> BoxList { get; set; } = new List<List<string>>();
}
}

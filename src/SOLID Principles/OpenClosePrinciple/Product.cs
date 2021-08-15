using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosePrinciple
{
    internal enum Color
    {
        Red, Green, Blue
    }

    internal enum Size
    {
        Small, Medium, Large
    }

    internal class Product
    {
        public Product(string name, Color color, Size size)
        {
            this.Name = name;
            this.Color = color;
            this.Size = size;
        }

        public string Name { get; }
        public Color Color { get; }
        public Size Size { get; }
    }
}

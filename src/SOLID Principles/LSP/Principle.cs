namespace LSP
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public abstract class Shape
    {
        public abstract int Area();
    }

    public class Rectangle : Shape
    {
        public Rectangle()
        {
        }

        public Rectangle(int height, int width)
        {
            Height = height;
            Width = width;
        }

        public int Height { get; set; }

        public int Width { get; set; }

        public override int Area()
        {
            return Height * Width;
        }

        public override string ToString()
        {
            return $"{nameof(Width)} : {Width}, {nameof(Height)}: {Height}";
        }
    }

    public class Square : Shape
    {

        public Square(int side)
        {
            Side = side;
        }
        public int Side { get; set; }


        public override int Area()
        {
            return Side * Side;
        }
        public override string ToString()
        {
            return $"{nameof(Side)} : {Side}";
        }

    }
}

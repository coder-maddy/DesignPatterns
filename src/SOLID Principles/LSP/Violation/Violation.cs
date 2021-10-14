namespace LSP.Violation
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Rectangle
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

        public override string ToString()
        {
            return $"{nameof(Width)} : {Width}, {nameof(Height)}: {Height}";
        }
    }

    public class Square : Rectangle
    {
        public new int Width
        {
            set
            {
                base.Width = base.Height = value;
            }
        }

        public new int Height
        {
            set
            {
                base.Height = base.Width = value;
            }
        }
    }
}

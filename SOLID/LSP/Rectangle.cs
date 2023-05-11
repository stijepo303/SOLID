using System;
namespace SOLID.LSP
{
    public class Rectangle : Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public override int Area()
        {
            return Width * Height;
        }
    }
}


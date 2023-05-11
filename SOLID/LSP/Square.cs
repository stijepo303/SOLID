using System;
namespace SOLID.LSP
{
    public class Square : Shape
    {
        public int Side { get; set; }

        public override int Area()
        {
            return Side * Side;
        }
    }
}


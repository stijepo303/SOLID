using System;
namespace SOLID.LSP
{
    public class CalculateArea
    {
        public CalculateArea(Shape shape)
        {
            if (shape is Rectangle rectangle)
            {
                rectangle.Height = 10;
                rectangle.Width = 7;
            }
            else if (shape is Square square)
            {
                square.Side = 12;
            }

            int area = shape.Area();
            Console.WriteLine($"Area: {area}");
        }
    }
}


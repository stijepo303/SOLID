using System;
namespace SOLID.LSP
{
    public class Shape
    {
        public virtual int Area()
        {
            throw new NotImplementedException();
        }
        public string Type { get; set; }
    }
}


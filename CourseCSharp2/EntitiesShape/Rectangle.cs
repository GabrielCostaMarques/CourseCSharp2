
using CourseCSharp2.EntitiesShape.Enums;

namespace CourseCSharp2.EntitiesShape
{
    internal class Rectangle : Shape
    {

        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height,Color color) : base(color)
        {
            Width = width;
            Height = height;
            
        }


        public override double Area()
        {
          return Width * Height;
        }
    }
}

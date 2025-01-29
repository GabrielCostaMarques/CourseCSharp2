using CourseCSharp2.EntitiesShape.Enums;


namespace CourseCSharp2.EntitiesShape
{
    internal abstract class Shape
    {
        public Color Color { get; set; }


        public Shape(Color color) { 
            Color = color;
        }

        public abstract double Area();
        
    }


}

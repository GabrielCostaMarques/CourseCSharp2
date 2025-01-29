
using CourseCSharp2.EntitiesShape.Enums;

namespace CourseCSharp2.EntitiesShape
{
    internal class Circle : Shape
    {
        public Circle(double raio,Color color) : base(color)
        {
            Raio = raio;
        }

        public double Raio { get; set; }

        public override double Area()
        {
            return Math.PI * Raio * Raio;
        }
    }
}

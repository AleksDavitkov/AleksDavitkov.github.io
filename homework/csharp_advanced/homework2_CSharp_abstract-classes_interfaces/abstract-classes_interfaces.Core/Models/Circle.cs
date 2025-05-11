using abstract_classes_interfaces.Core.Interfaces;
using abstract_classes_interfaces.Core.Abstract;

namespace abstract_classes_interfaces.Core.Models
{
    public class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double CalculateArea()
        {
            return Math.PI * Math.Pow(Radius, 2); // Had to look up the built in constants for these
        }

        public override double CalculatePerimeter()
        {
            return 2 * Math.PI * Radius;
        }

        public override double GetArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
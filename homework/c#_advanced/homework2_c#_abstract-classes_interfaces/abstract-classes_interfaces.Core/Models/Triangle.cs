using abstract_classes_interfaces.Core.Interfaces;
using abstract_classes_interfaces.Core.Abstract;

namespace abstract_classes_interfaces.Core.Models
{
    public class Triangle : Shape
    {
        public double Base { get; set; }
        public double Height { get; set; }
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }

        public Triangle(double baseLength, double height, double sideA, double sideB, double sideC)
        {
            Base = baseLength;
            Height = height;
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        public Triangle(double baseLength, double height)
        {
            Base = baseLength;
            Height = height;
        }

        public override double CalculateArea()
        {
            return 0.5 * Base * Height;
        }

        public override double CalculatePerimeter()
        {
            return SideA + SideB + SideC; // sum of all sides
        }

        public override double GetArea()
        {
            return 0.5 * Base * Height;
        }
    }
}
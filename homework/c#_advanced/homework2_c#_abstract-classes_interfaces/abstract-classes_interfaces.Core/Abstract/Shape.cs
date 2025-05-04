using abstract_classes_interfaces.Core.Interfaces;

namespace abstract_classes_interfaces.Core.Abstract
{
    public abstract class Shape : IShape
    {
        public abstract double CalculateArea();
        public abstract double CalculatePerimeter();
        public abstract double GetArea();
    }
}
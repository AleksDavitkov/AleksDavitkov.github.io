using polymorphism_static_classes.Core.Domain.Entities;

namespace polymorphism_static_classes.Core.Domain.Models
{
    public class Car : Vehicle
    {
        public override void DisplayInfo()
        {
            Console.WriteLine("I'm a car and I drive on 4 wheels :)");
        }
    }
}
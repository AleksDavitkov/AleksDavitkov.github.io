using polymorphism_static_classes.Core.Domain.Entities;

namespace polymorphism_static_classes.Core.Domain.Models
{
    public class MotorBike : Vehicle
    {
        public override void DisplayInfo()
        {
            Console.WriteLine("I'm a motorbike and I drive on 2 wheels :)");
        }
    }
}
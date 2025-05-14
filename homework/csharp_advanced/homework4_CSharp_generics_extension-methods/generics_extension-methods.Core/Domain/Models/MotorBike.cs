using generics_extension_methods.Core.Domain.Entities;

namespace generics_extension_methods.Core.Domain.Models
{
    public class MotorBike : Vehicle
    {
        public override void DisplayInfo()
        {
            Console.WriteLine("I'm a motorbike and I drive on 2 wheels :)");
        }
    }
}
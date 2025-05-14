using generics_extension_methods.Core.Domain.Entities;

namespace generics_extension_methods.Core.Domain.Models
{
    public class Car : Vehicle
    {
        public override void DisplayInfo()
        {
            Console.WriteLine("I'm a car and I drive on 4 wheels :)");
        }
    }
}
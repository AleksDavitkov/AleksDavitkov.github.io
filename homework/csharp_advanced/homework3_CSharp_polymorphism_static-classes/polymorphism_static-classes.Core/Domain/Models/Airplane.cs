using polymorphism_static_classes.Core.Domain.Entities;

namespace polymorphism_static_classes.Core.Domain.Models
{
    public class Airplane : Vehicle
    {
        public override void DisplayInfo()
        {
            Console.WriteLine("I'm a plane and I have a couple of wheels :)");
        }
    }
}
using generics_extension_methods.Core.Domain.Entities;

namespace generics_extension_methods.Core.Domain.Models
{
    public class Airplane : Vehicle
    {
        public override void DisplayInfo()
        {
            Console.WriteLine("I'm a plane and I have a couple of wheels :)");
        }
    }
}
using generics_extension_methods.Core.Domain.Entities;

namespace generics_extension_methods.Core.Domain.Models
{
    public class Boat : Vehicle
    {
        public override void DisplayInfo()
        {
            Console.WriteLine("I'm a boat and I do not have wheels :(");
        }
    }
}
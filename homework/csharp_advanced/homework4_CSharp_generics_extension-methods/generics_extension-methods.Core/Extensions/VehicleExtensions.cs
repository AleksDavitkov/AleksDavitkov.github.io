using generics_extension_methods.Core.Domain.Models;

namespace generics_extension_methods.Core.Extensions
{
    public static class VehicleExtensions
    {
        public static void Drive(this Car car)
        {
            Console.WriteLine("The car is driving");
        }

        public static void Wheelie(this MotorBike motorBike)
        {
            Console.WriteLine("The motorbike is driving on one wheel");
        }

        public static void Sail(this Boat boat)
        {
            Console.WriteLine("The boat is sailing");
        }

        public static void Fly(this Airplane airplane)
        {
            Console.WriteLine("The airplane is flying");
        }
    }
}
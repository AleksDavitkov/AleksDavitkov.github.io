using generics_extension_methods.Core.Domain.Entities;
using generics_extension_methods.Core.Domain.Models;
using generics_extension_methods.Core.Extensions;
using generics_extension_methods.Core.Utilities.Helpers;

// 01
string name = "Bob";
string lastName = "Bobsky";

List<string> buildNotes = new List<string>()
{
    "CodeReady",
    "ViewingComplete",
    "ProductionDeploy",
    "TaskLogs_09.20"
};

PrintInConsole printInConsole = new();
printInConsole.Print(name, lastName);
printInConsole.PrintCollection(buildNotes);

// 02
Vehicle car = new Car();
Vehicle motorBike = new MotorBike();
Vehicle boat = new Boat();
Vehicle plane = new Airplane();

car.DisplayInfo();
motorBike.DisplayInfo();
boat.DisplayInfo();
plane.DisplayInfo();

// 03
Car car1 = new Car();
MotorBike motorBike1 = new MotorBike();
Boat boat1 = new Boat();
Airplane plane1 = new Airplane();

car1.Drive();
motorBike1.Wheelie();
boat1.Sail();
plane1.Fly();
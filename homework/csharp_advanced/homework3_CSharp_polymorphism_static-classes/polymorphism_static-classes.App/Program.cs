using polymorphism_static_classes.Core.DataAccess;
using polymorphism_static_classes.Core.Domain.Entities;
using polymorphism_static_classes.Core.Domain.Models;
using polymorphism_static_classes.Core.Utilities.Helpers;

// 01
User userById = UserDB.SearchById(3);
PrintUserHelper.Print(userById);

List<User> users = UserDB.SearchByName("Bob");
PrintUserHelper.Print(users);

users = UserDB.SearchByAge(30);
PrintUserHelper.Print(users);

// PrintUserHelper > Method overloading polymorphism - different signature, handle different cases

// 02
Vehicle car = new Car();
Vehicle motorBike = new MotorBike();
Vehicle boat = new Boat();
Vehicle plane = new Airplane();

car.DisplayInfo();
motorBike.DisplayInfo();
boat.DisplayInfo();
plane.DisplayInfo();

// Base Vehicle > Child class. Method overriding polymorphism - inheritance
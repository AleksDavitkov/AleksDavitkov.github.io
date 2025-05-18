using homework5.Domain;
using homework5.Domain.DataAccess;

Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("LINQ recap Vol.2");
Console.ResetColor();

// 01
List<Car> europeanCars = CarsData.Cars
    .Where(car => car.Origin == "Europe")
    .ToList();

europeanCars.ForEach(car => Console.WriteLine(car.Model));

// 02
List<int> uniqueCylinders = CarsData.Cars
    .Select(car => car.Cylinders)
    .Distinct()
    .ToList();

uniqueCylinders.ForEach(cyl => Console.WriteLine($"Cylinders: {cyl}"));

// 03
List<string> upperCaseModels = CarsData.Cars
    .Select(car => car.Model.ToUpper())
    .ToList();

upperCaseModels.ForEach(model => Console.WriteLine(model));

// 04
bool hasPowerfulCars = CarsData.Cars.Any(car => car.HorsePower > 300);

Console.WriteLine($"Horsepower > 300? {hasPowerfulCars}");

// 05
Car mostPowerfulCar = CarsData.Cars
    .OrderByDescending(car => car.HorsePower)
    .FirstOrDefault();

Console.WriteLine($"{mostPowerfulCar.Model} with {mostPowerfulCar.HorsePower} HP");

// 06
List<Car> chevroletCarsByWeight = CarsData.Cars
    .Where(car => car.Model.Contains("Chevrolet"))
    .OrderByDescending(car => car.Weight)
    .ToList();

chevroletCarsByWeight.ForEach(car => Console.WriteLine($"{car.Model} - Weight: {car.Weight}"));

// 07
Car longestModelCar = CarsData.Cars
    .OrderByDescending(car => car.Model.Length)
    .FirstOrDefault();

Console.WriteLine($"{longestModelCar.Model} - Length: {longestModelCar.Model.Length}");

// 08
var carsByOrigin = CarsData.Cars
    .GroupBy(car => car.Origin)
    .OrderBy(car => car.Count())
    .ToList();

// 09
List<Car> top5PowerfulCars = CarsData.Cars
    .OrderByDescending(car => car.HorsePower)
    .Take(5)
    .ToList();

top5PowerfulCars.ForEach(car => Console.WriteLine($"{car.Model} - Horsepower: {car.HorsePower}"));

// 10
Car slowestAcceleratingCar = CarsData.Cars
    .OrderByDescending(car => car.AccelerationTime)
    .FirstOrDefault();

Console.WriteLine($"{slowestAcceleratingCar.Model} - Acceleration Time: {slowestAcceleratingCar.AccelerationTime}");

// 11
var powerfulCars = CarsData.Cars
    .Where(car => car.HorsePower > 200)
    .Select(car => new { car.Model, car.HorsePower })
    .ToList();

powerfulCars.ForEach(car => Console.WriteLine($"{car.Model} - Horsepower: {car.HorsePower}"));

// 12
List<string> uniqueOrigins = CarsData.Cars
    .Select(car => car.Origin)
    .Distinct()
    .OrderBy(origin => origin)
    .ToList();

uniqueOrigins.ForEach(origin => Console.WriteLine(origin));

// 13
List<Car> filteredCars = CarsData.Cars
    .Where(car => car.Cylinders > 4)
    .OrderBy(car => car.Origin)
    .ThenBy(car => car.HorsePower)
    .ToList();

filteredCars.ForEach(car => Console.WriteLine($"{car.Model} - Cylinders: {car.Cylinders}, Horsepower: {car.HorsePower}"));

// 14
List<Car> filterCylinderCars = CarsData.Cars
    .Where(car => car.Cylinders > 6)
    .Concat(
        CarsData.Cars.Where(car => car.Cylinders == 4 && car.HorsePower > 110.0)
    )
    .ToList();

filterCylinderCars.ForEach(car => Console.WriteLine($"{car.Model} - Cylinders: {car.Cylinders}, Horsepower: {car.HorsePower}"));

// 15
List<Car> powerfulCarsHp = CarsData.Cars
    .Where(car => car.HorsePower > 200 && car.MilesPerGalon > 0)
    .ToList();

double minMpg = powerfulCarsHp.Min(car => car.MilesPerGalon);
double maxMpg = powerfulCarsHp.Max(car => car.MilesPerGalon);
double avgMpg = powerfulCarsHp.Average(car => car.MilesPerGalon);

Console.WriteLine($"Min MPG: {minMpg}");
Console.WriteLine($"Max MPG: {maxMpg}");
Console.WriteLine($"Avg MPG: {avgMpg:F2}");

// 16
var lightestCarsByCylinderGroup = CarsData.Cars
    .GroupBy(car => car.Cylinders)
    .Where(b => b.Count() >= 2)
    .Select(b => b.OrderBy(car => car.Weight).First())
    .OrderBy(car => car.Cylinders)
    .ToList();

lightestCarsByCylinderGroup.ForEach(car => Console.WriteLine($"{car.Model}, Cylinders: {car.Cylinders}, Weight: {car.Weight}"));

// 17
var powerfulUsCars = CarsData.Cars
    .Where(car => car.Origin == "US" && car.HorsePower > 150)
    .OrderBy(car => car.Model)
    .Select(car => new { car.Model, car.HorsePower })
    .ToList();

powerfulUsCars.ForEach(car => Console.WriteLine($"{car.Model} - HP: {car.HorsePower}"));
namespace classes.RaceCars.App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Driver[] drivers = Drivers();
            Car[] cars = Cars(drivers);

            Car.RaceCars(cars[0], cars[2]);
            Car.RaceCars(cars[1], cars[3]);

            // OR Let the user select cars for the race
            RaceAgain(cars);
        }

        static Driver[] Drivers()
        {
            return new Driver[]
            {
                new Driver("Bob", 66),
                new Driver("Greg", 83),
                new Driver("Jill", 68),
                new Driver("Ane", 83)
            };
        }

        // Cars assigned to designated drivers
        static Car[] Cars(Driver[] drivers)
        {
            return new Car[]
            {
                new Car("Ferrari", 240, drivers[0]),
                new Car("Porsche", 220, drivers[1]),
                new Car("Mercedes", 230, drivers[2]),
                new Car("Opel Astra", 220, drivers[3])
            };
        }

        static Car[] SelectCars(Car[] cars)
        {
            // I could go on here with additional input validation and error handling though I think it's good enough for now

            Console.WriteLine("\nChoose your first car for the race:");
            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {cars[i].Model}");
            }
            int firstCarChoice = int.Parse(Console.ReadLine()) - 1; // Here we subtract 1 from the user's input to match the array index (user friendly)

            Console.WriteLine("\nChoose your second car for the race:");
            for (int i = 0; i < cars.Length; i++)
            {
                if (i != firstCarChoice)
                {
                    Console.WriteLine($"{i + 1}. {cars[i].Model}");
                }
            }
            int secondCarChoice = int.Parse(Console.ReadLine()) - 1;

            return new Car[] { cars[firstCarChoice], cars[secondCarChoice] };
        }

        static void RaceAgain(Car[] cars)
        {
            bool raceAgain = true;
            while (raceAgain)
            {
                // Pulls from the SelectCars method
                Car[] selectedCars = SelectCars(cars);
                Car.RaceCars(selectedCars[0], selectedCars[1]);

                Console.WriteLine("\nDo you want to race again? (yes/no)");
                string userResponse = Console.ReadLine().ToLower();

                if (userResponse != "yes")
                {
                    raceAgain = false; // End loop if the user doesn't want to race again
                }
            }

            Console.WriteLine("Thank you for racing!");
        }
    }
}
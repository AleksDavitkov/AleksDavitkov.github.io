namespace classes.RaceCars.App
{
    class Car
    {
        public string Model { get; set; }
        public int Speed { get; set; }
        public Driver Driver { get; set; }

        public Car(string model, int speed, Driver driver)
        {
            Model = model;
            Speed = speed;
            Driver = driver;
        }

        public int CalculateSpeed(Driver driver)
        {
            return driver.Skill * Speed;
        }

        public static void RaceCars(Car raceCar1, Car raceCar2)
        {
            int car1Speed = raceCar1.CalculateSpeed(raceCar1.Driver);
            int car2Speed = raceCar2.CalculateSpeed(raceCar2.Driver);

            if (car1Speed > car2Speed)
            {
                Console.WriteLine($"{raceCar1.Driver.Name} with the {raceCar1.Model} won! Speed: {raceCar1.Speed} km/h, Driver's Skill: {raceCar1.Driver.Skill}");
            }
            else if (car2Speed > car1Speed)
            {
                Console.WriteLine($"{raceCar2.Driver.Name} with the {raceCar2.Model} won! Speed: {raceCar2.Speed} km/h, Driver's Skill: {raceCar2.Driver.Skill}");
            }
            else
            {
                Console.WriteLine("It's a tie! Maybe they should beer pong to settle their differences.");
            }
        }
    }
}
﻿using polymorphism_static_classes.Core.Domain.Entities;

namespace polymorphism_static_classes.Core.Domain.Models
{
    public class Boat : Vehicle
    {
        public override void DisplayInfo()
        {
            Console.WriteLine("I'm a boat and I do not have wheels :(");
        }
    }
}
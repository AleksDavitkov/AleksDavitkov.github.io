using System;
using abstract_classes_interfaces.Core.Abstract;
using abstract_classes_interfaces.Core.Interfaces;
using abstract_classes_interfaces.Core.Models;

// 01
ISearchable doc = new Document("Notes", "Interfaces are like contracts");
ISearchable page = new WebPage("https://example.com", "<html><body>404</body></html>");
// Instantiating objects through interfaces is an organized pipeline to enable polymorphism
// having different object types to be handled uniformly

Console.WriteLine("Interfaces in Document: " + doc.Search("interfaces"));
Console.WriteLine("C# on the WebPage: " + page.Search("C#"));

// 02
IShape rectangle = new Rectangle(5, 10);
IShape circle = new Circle(7);
IShape triangle = new Triangle(4, 8);

Console.WriteLine("Area of rectangle: " + rectangle.GetArea());
Console.WriteLine("Area of circle: " + circle.GetArea());
Console.WriteLine("Area of triangle:" + triangle.GetArea());

// 03
Shape circleTwo = new Circle(7);
Shape triangleTwo = new Triangle(4, 8, 3, 4, 5);

Console.WriteLine("Circle Area: " + circleTwo.CalculateArea());
Console.WriteLine("Circle Perimeter: " + circleTwo.CalculatePerimeter());

Console.WriteLine("Triangle Area: " + triangleTwo.CalculateArea());
Console.WriteLine("Triangle Perimeter: " + triangleTwo.CalculatePerimeter());

// 04
Employee manager = new Manager("James", 37, 3000, 1500, 12, 12);
Employee programmer = new Programmer("Bob", 26, 1000, 300, 5, 40);

manager.DisplayInfo();
manager.CalculateSalary();

programmer.DisplayInfo();
programmer.CalculateSalary();
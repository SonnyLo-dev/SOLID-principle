// See https://aka.ms/new-console-template for more information


// Liskov Substitution Principle Compliant
var shapes = new List<IShape>
{
    new Rectangle { Width = 5, Height = 10 },
    new Circle { Radius = 7 }
};

var areaCalculator = new AreaCalculator();
Console.WriteLine("Total Area (Liskov Substitution Principle): " + areaCalculator.CalculateTotalArea(shapes));


// Keep the console window open
Console.ReadLine();
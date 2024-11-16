// See https://aka.ms/new-console-template for more information

// Objects or entities should be open for extension but closed for modification.

// Using AreaCalculator
var shapes = new List<IShape>
        {
            new Rectangle { Width = 5, Height = 10 },
            new Circle { Radius = 7 }
        };

var areaCalculator = new AreaCalculator();
Console.WriteLine("Total Area (Open-Closed Principle): " + areaCalculator.CalculateTotalArea(shapes));

// Using OpenCloseViolation
var openCloseViolation = new OpenCloseViolation();
double rectangleArea = openCloseViolation.CalculateRectangleArea(5, 10);
double circleArea = openCloseViolation.CalculateCircleArea(7);
Console.WriteLine("Rectangle Area (Violation): " + rectangleArea);
Console.WriteLine("Circle Area (Violation): " + circleArea);

// Keep the console window open
Console.ReadLine();


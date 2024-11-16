using System;

public class OpenCloseViolation
{
    public double CalculateRectangleArea(double width, double height)
    {
        return width * height;
    }

    public double CalculateCircleArea(double radius)
    {
        return Math.PI * radius * radius;
    }
}

using System;

public class OpenCloseViolation
{
	public double TotalArea(object[] shapeObject)
	{
		double area = 0;
        Rectangle rectangle;
		Circle circle;

		foreach(var obj in shapeObject)
		{
			if (obj is Rectangle)
            {
                area += obj.Height * obj.Width;
            }
            else if (obj is Circle)
            {
                area += obj.Radius * obj.Radius * Math.PI;
            }
            else
            {
                throw new Exception("Shape type not supported");
            }

            return area;
        }

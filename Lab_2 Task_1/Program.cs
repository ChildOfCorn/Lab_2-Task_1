using System;

class Rectangle
{
	private double side1;
	private double side2;

	public Rectangle(double side1, double side2)
	{
		this.side1 = side1;
		this.side2 = side2;
	}

	public double CalculateArea()
	{
		return side1 * side2;
	}

	public double CalculatePerimeter()
	{
		return 2 * (side1 + side2);
	}

	public double Area
	{
		get { return CalculateArea(); }
	}

	public double Perimeter
	{
		get { return CalculatePerimeter(); }
	}
}

class Program
{
	static void Main(string[] args)
	{
		Console.Write("Enter the length of the first side of the rectangle: ");
		double side1 = double.Parse(Console.ReadLine());

		Console.Write("Enter the length of the other side of the rectangle: ");
		double side2 = double.Parse(Console.ReadLine());

		Rectangle rectangle = new Rectangle(side1, side2);

		Console.WriteLine($"Area of a rectangle: {rectangle.Area}");
		Console.WriteLine($"Perimeter of a rectangle: {rectangle.Perimeter}");
	}
}

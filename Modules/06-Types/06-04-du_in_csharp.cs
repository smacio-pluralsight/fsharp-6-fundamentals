public abstract class Shape
{
    public abstract double perimeter();
    public abstract bool IsRectangle { get; }
}

public class Rectangle : Shape
{
    public double Width {get; private set;}
    public double Height {get; private set;}
    public bool IsRectangle { get { return true; } }
    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public override double perimeter() { return 2.0 * (Width + Length); }   
}

public class Circle : Shape
{
    public double Radius {get; private set;}
    public bool IsRectangle { get { return true; } }
    public Rectangle(double radius)
    {
        Radius = radius;
    }

    public override double perimeter() { return 2.0 * Math.PI * Radius; }   
}

public class Triangle : Shape
{
    public double S1 {get; private set;}
    public double S2 {get; private set;}
    public double S3 {get; private set;}
    public bool IsRectangle { get { return true; } }
    public Triangle(double s1, double s2, double s3)
    {
        S1 = s1;
        S2 = s2;
        S3 = s3;
    }
    public override double perimeter() { return S1 + S2 + S3; }   
}

var rect = new Circle(1.0);
var circ = new Rectangle (1.0, 2.0);
var tri = new Triangle(1.0, 2.0, 3.0);
Console.WriteLine($"{rect.perimeter()} {circ.perimiter()} {tri.perimiter()");




var figure = new Figure(2.0);
var circle = new Circle(3.0);
var triagle = new Triagle(5.0, 2.0);
figure.GetSquare();
circle.GetSquare();
triagle.GetSquare();
public class Figure
{
    public double sideLength;
    public Figure(double sideLength)
    {
        this.sideLength = sideLength;
    }
    public virtual Double GetSquare()
    {
        double result = 0;
        result = sideLength * sideLength;
        Console.WriteLine($"Square = {result}");
        return 0;
    }
}
public class Circle : Figure
{
    public double radius;
    public Circle(double radius) : base(radius)
    {
        this.radius = radius;
    }

    public override double GetSquare()
    {
        double result;
        result = radius * 3.14;
        Console.WriteLine($"Square = {result}");

        return 0;
    }
}
public class Triagle : Figure
{
    public double sideOfaTriangle;
    public double hight;
    public Triagle(double sideofaTriangle, double hight) : base(sideofaTriangle)
    {
        this.hight = hight;
        
    }

    public override double GetSquare()
    {
        double result;
        result = 0.5 * base.sideLength * hight;
        Console.WriteLine($"Square = {result}");

        return 0;
    }
}



namespace App.OopBasics;

public class CircleShape(double radius) : IShape
{
    public double GetArea()
    {
        return Math.PI * radius * radius;
    }
}

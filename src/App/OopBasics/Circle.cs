namespace App.OopBasics;

public class Circle(int x, int y, int radius)
{
    public readonly int x = x;
    public int y = y;
    public int radius = radius;

    public Circle(int radius)
        : this(0, 0, radius) { }

    public double GetCircumference()
    {
        return radius * 2 * Math.PI;
    }
}

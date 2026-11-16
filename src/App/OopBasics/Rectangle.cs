namespace App.OopBasics;

public class Rectangle(double height, double length) : IShape
{
    private double Height { get; } = height;
    private double Length { get; } = length;

    public double GetArea()
    {
        return Height * Length;
    }
}

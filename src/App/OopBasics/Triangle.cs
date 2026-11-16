namespace App.OopBasics;

public class Triangle
{
    public static double ToRadians(int grad)
    {
        return (grad * Math.PI) / 180;
    }

    public static double Area(int side1, int side2, int grad)
    {
        return Math.Round((side1 * side2 / 2.0) * Math.Sin(ToRadians(grad)), 5);
    }
}

namespace App.OopBasics;

public class Theory
{
    public static Point GetMidpoint(Point point1, Point point2)
    {
        var midX = (point1.GetX() + point2.GetX()) / 2;
        var midY = (point1.GetY() + point2.GetY()) / 2;

        return new Point(midX, midY);
    }
}

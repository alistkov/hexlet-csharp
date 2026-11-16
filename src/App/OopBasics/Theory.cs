using App.OopBasics;

namespace App.OopBasics;

public class Theory
{
    public static Point GetMidpoint(Point point1, Point point2)
    {
        var midX = (point1.GetX() + point2.GetX()) / 2;
        var midY = (point1.GetY() + point2.GetY()) / 2;

        return new Point(midX, midY);
    }

    public static bool HasDuplicates(string[] tags)
    {
        var processed = new string[tags.Length];
        var count = 0;

        foreach (var tag in tags)
        {
            var processedTag = tag.Trim().ToLowerInvariant();

            if (processed.Contains(processedTag))
            {
                return true;
            }

            processed[count] = processedTag;
            count += 1;
        }

        return false;
    }
}

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

    public static double? AverageTemperature(int?[] temperature)
    {
        double totalTemperature = 0;
        var notEmptyCounts = 0;

        foreach (var t in temperature)
        {
            if (t is not null)
            {
                totalTemperature += (double)t;
                notEmptyCounts += 1;
            }
        }

        return notEmptyCounts == 0 ? null : totalTemperature / notEmptyCounts;
    }

    public static double TotalArea(IShape[] shapes)
    {
        if (shapes.Length == 0)
        {
            return 0;
        }

        double totalArea = 0;

        foreach (var shape in shapes)
        {
            totalArea += shape.GetArea();
        }

        return totalArea;
    }

    public static int ParseOrDefault(string number, int defaultValue)
    {
        try
        {
            return int.Parse(number);
        }
        catch (FormatException)
        {
            return defaultValue;
        }
    }

    public static void SumQuantities(string[] data)
    {
        foreach (var item in data)
        {
            try
            {
                var number = int.Parse(item);
                Console.WriteLine(number);
            }
            catch (OverflowException)
            {
                Console.WriteLine($"Слишком большое число: {item}");
            }
            catch (Exception)
            {
                Console.WriteLine($"Пропущено: {item}");
            }
        }
    }
}

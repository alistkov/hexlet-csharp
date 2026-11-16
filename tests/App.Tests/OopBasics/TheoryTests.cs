using App.OopBasics;

namespace App.Tests.OopBasics;

public class TheoryTests
{
    [Fact]
    public void GetMidpoint()
    {
        var point1 = new Point(2, 4);
        var point2 = new Point(4, 6);
        var midPoint = Theory.GetMidpoint(point1, point2);
        Assert.Equal(3, midPoint.GetX());
        Assert.Equal(5, midPoint.GetY());
    }

    [Fact]
    public void GetMidpointWithNegativeAndFractional()
    {
        var first = new Point(-3, 5);
        var second = new Point(2, -1);
        var middle = Theory.GetMidpoint(first, second);
        Assert.Equal(-0.5, middle.GetX());
        Assert.Equal(2.0, middle.GetY());
    }

    [Fact]
    public void GetMidpointReturnsNewPoint()
    {
        var first = new Point(1, 1);
        var second = new Point(1, 1);
        var middle = Theory.GetMidpoint(first, second);

        Assert.False(ReferenceEquals(middle, first));
        Assert.False(ReferenceEquals(middle, second));
        Assert.Equal(1.0, middle.GetX());
        Assert.Equal(1.0, middle.GetY());
    }

    [Fact]
    public void AverageTemperature()
    {
        int?[] temperature = [1, 2, 3, 4, 5, 6, 7, 8];
        Assert.Equal(4.5, Theory.AverageTemperature(temperature));

        int?[] temperatureWithZero = [-2, -4, 0, 4, 2, 0, -1, 3];
        Assert.Equal(0.25, Theory.AverageTemperature(temperatureWithZero));

        int?[] temperatureWithNull = [-2, -4, null, 4, 2, null, -1, 3];
        Assert.Equal(0.3333, Theory.AverageTemperature(temperatureWithNull)!.Value, 4);

        int?[] temperatureWithoutValues = [null, null, null];
        Assert.Null(Theory.AverageTemperature(temperatureWithoutValues));
    }

    [Fact]
    public void TotalArea()
    {
        IShape[] shapes =
        [
            new CircleShape(5),
            new Rectangle(2, 4),
            new Rectangle(3, 8),
            new CircleShape(1.5),
        ];

        Assert.Equal(117.6084, Theory.TotalArea(shapes), 4);
        Assert.Equal(0, Theory.TotalArea([]));
    }

    [Fact]
    public void ParseOrDefault()
    {
        Assert.Equal(5, Theory.ParseOrDefault("5", 4));
        Assert.Equal(2, Theory.ParseOrDefault("number", 2));
        Assert.Equal(3, Theory.ParseOrDefault("", 3));
    }
}

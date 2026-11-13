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
}

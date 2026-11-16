using App.OopBasics;

namespace App.Tests.OopBasics;

public class CircleShapeTests
{
    [Fact]
    public void CircleShapeImplementsIShape()
    {
        var circle = new CircleShape(5);
        Assert.IsAssignableFrom<IShape>(circle);
    }

    [Theory]
    [InlineData(0, 0)]
    [InlineData(1.5, 7.068583)]
    [InlineData(5, 78.539816)]
    public void GetAreaReturnsAreaForRadius(double radius, double expectedArea)
    {
        var circle = new CircleShape(radius);

        Assert.Equal(expectedArea, circle.GetArea(), 6);
    }
}

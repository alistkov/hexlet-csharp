using App.OopBasics;

namespace App.Tests.OopBasics;

public class CircleTests
{
    [Fact]
    public void CircleWithPoint()
    {
        var circle = new Circle(2, 4, 10);
        
        Assert.Equal(2, circle.x);
        Assert.Equal(4, circle.y);
        Assert.Equal(10, circle.radius);
    }

    [Fact]
    public void CircleWithRadiusOnly()
    {
        var circle = new Circle(15);
        Assert.Equal(0, circle.x);
        Assert.Equal(0, circle.y);
        Assert.Equal(15, circle.radius);
    }

    [Fact]
    public void GetCircumference()
    {
        Assert.Equal(31.4159, new Circle(1, 2, 5).GetCircumference(), 4);
        Assert.Equal(62.8319, new Circle(10).GetCircumference(), 4);
        Assert.Equal(0, new Circle(3, 4, 0).GetCircumference(), 6);
    }

    [Fact]
    public void GetCircumferenceAfterFieldChange()
    {
        var first = new Circle(10);
        var second = new Circle(10);
        first.radius = 3;
        Assert.Equal(18.8496, first.GetCircumference(), 4);
        Assert.Equal(62.8319, second.GetCircumference(), 4);
    }
}

using App.OopBasics;

namespace App.Tests.OopBasics;

public class RectangleTests
{
    [Fact]
    public void Rectangle()
    {
        var rectangle = new Rectangle(4, 5);
        Assert.Equal(20, rectangle.GetArea());
        Assert.IsAssignableFrom<IShape>(rectangle);

    }
}

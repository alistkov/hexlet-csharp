using App.OopBasics;

namespace App.Tests.OopBasics;

public class TriangleTests
{
    [Fact]
    public void ToRadiansTests()
    {
        Assert.Equal(3.141592653589793, Triangle.ToRadians(180));
        Assert.Equal(1.5707963267948966, Triangle.ToRadians(90));
        Assert.Equal(0, Triangle.ToRadians(0));
    }

    [Fact]
    public void AreaTests()
    {
        Assert.Equal(43.30127, Triangle.Area(10, 10, 60), 5);
        Assert.Equal(7.07107, Triangle.Area(4, 5, 45), 5);
        Assert.Equal(10, Triangle.Area(4, 5, 90), 5);
        Assert.Equal(0, Triangle.Area(4, 5, 0), 5);
    }
}

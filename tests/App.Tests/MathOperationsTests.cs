namespace App.Tests;

public class MathOperationsTests
{
    [Fact]
    public void AddTest()
    {
        Assert.Equal(6, MathOperations.Add(2, 4));
    }

    [Fact]
    public void SubtractionTest()
    {
        Assert.Equal(4, MathOperations.Subtraction(11, 7));
    }
}
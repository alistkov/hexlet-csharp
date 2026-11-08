using App.FundamentalsMethods;

namespace App.Tests.FundamentalsMethods;

public class TheoryTests
{
    [Fact]
    public void MethodsTests()
    {
        var expected = "HODOR says: \"hodor\"";
        Assert.Equal(expected, Theory.Methods());
    }

    [Fact]
    public void MethodsParametersTests()
    {
        var expected = "h o d o r";
        Assert.Equal(expected, Theory.MethodsParameters());
    }

    [Fact]
    public void PropertiesTests()
    {
        var expected = "Robert I Baratheon has 18 characters in his name";
        Assert.Equal(expected, Theory.Properties());
    }

    [Fact]
    public void MethodsAsExpressionsTest()
    {
        var expected = "First: N\nLast: t";
        Assert.Equal(expected, Theory.MethodsAsExpressions());
    }
}

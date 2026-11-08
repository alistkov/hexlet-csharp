using App.FundamentalsMethods;

namespace App.Tests.FundamentalsMethods;

public class TheoryTests
{
    [Fact]
    public void MethodsTest()
    {
        var expected = "HODOR says: \"hodor\"";
        Assert.Equal(expected, Theory.Methods());
    }

    [Fact]
    public void MethodsParametersTest()
    {
        var expected = "h o d o r";
        Assert.Equal(expected, Theory.MethodsParameters());
    }
}

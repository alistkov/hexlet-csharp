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

    [Fact]
    public void StringImmutabilityTest()
    {
        Assert.Equal("support@hexlet.io", Theory.StringImmutability(" SupporT@hexlet.io\n"));
    }

    [Fact]
    public void MethodsChainTests()
    {
        Assert.Equal("Hexlet", Theory.MethodsChain(" hexlet\n"));
        Assert.Equal("Hexlet", Theory.MethodsChain(" hexlEt"));
    }

    [Fact]
    public void MethodsDeterministicTests()
    {
        for (int i = 0; i < 30; i++)
        {
            Assert.InRange(Theory.MethodsDeterministic(), 0, 9);
        }
    }

    [Fact]
    public void StdlibTests()
    {
        var war = "War of the Kings";
        var missingWord = "Five ";
        
        Assert.Equal("War of the Five Kings", Theory.Stdlib(war, missingWord, "Kings"));
    }
}

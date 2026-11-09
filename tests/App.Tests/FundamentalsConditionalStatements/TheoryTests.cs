using App.FundamentalsConditionalStatements;

namespace App.Tests.FundamentalsConditionalStatements;

public class TheoryTests
{
    [Fact]
    public void IsPensionerTest()
    {
        Assert.True(Theory.IsPensioner(64));
        Assert.True(Theory.IsPensioner(60));
        Assert.False(Theory.IsPensioner(48));
    }

    [Fact]
    public void IsMisterTests()
    {
        Assert.True(Theory.IsMister("Mister"));
        Assert.False(Theory.IsMister("Not Mister"));
    }
}

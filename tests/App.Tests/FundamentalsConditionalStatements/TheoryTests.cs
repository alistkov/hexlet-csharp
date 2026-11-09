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

    [Fact]
    public void IsInternationalPhoneTests()
    {
        Assert.True(Theory.IsInternationalPhone("+7491234567"));
        Assert.False(Theory.IsInternationalPhone("8491234567"));
    }

    [Fact]
    public void IsLannisterSoldierTests()
    {
        Assert.True(Theory.IsLannisterSoldier("red", null));
        Assert.True(Theory.IsLannisterSoldier("green", "lion"));
        Assert.False(Theory.IsLannisterSoldier("green", null));
        Assert.False(Theory.IsLannisterSoldier("red", "man"));
    }
}

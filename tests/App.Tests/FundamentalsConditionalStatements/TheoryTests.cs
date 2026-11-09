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
    
    [Fact]
    public void IsNotLannisterSoldierTests()
    {
        Assert.False(Theory.IsNotLannisterSoldier("red", null));
        Assert.False(Theory.IsNotLannisterSoldier("green", "lion"));
        Assert.True(Theory.IsNotLannisterSoldier("green", null));
        Assert.True(Theory.IsNotLannisterSoldier("red", "man"));
    }

    [Fact]
    public void IsNeutralSoldierTests()
    {
        Assert.True(Theory.IsNeutralSoldier("yellow", "black"));
        Assert.True(Theory.IsNeutralSoldier("black", "black"));
        
        Assert.False(Theory.IsNeutralSoldier("red", "red"));
        Assert.False(Theory.IsNeutralSoldier("yellow", "red"));
        Assert.False(Theory.IsNeutralSoldier("black", "red"));
        
        Assert.False(Theory.IsNeutralSoldier("red", "yellow"));
        Assert.False(Theory.IsNeutralSoldier("yellow", "yellow"));
        Assert.False(Theory.IsNeutralSoldier("black", "yellow"));
    }
}

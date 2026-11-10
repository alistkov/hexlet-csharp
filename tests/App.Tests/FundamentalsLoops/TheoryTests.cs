using App.FundamentalsLoops;

namespace App.Tests.FundamentalsLoops;

public class TheoryTests
{
    [Fact]
    public void MultiplyNumbersFromRangeTests()
    {
        Assert.Equal(0, Theory.MultiplyNumbersFromRange(0, 5));
        Assert.Equal(-24, Theory.MultiplyNumbersFromRange(-4, -2));
        Assert.Equal(6, Theory.MultiplyNumbersFromRange(6, 6));
        Assert.Equal(6, Theory.MultiplyNumbersFromRange(2, 3));
        Assert.Equal(120, Theory.MultiplyNumbersFromRange(1, 5));
    }

    [Fact]
    public void JoinNumbersFromRangeTests()
    {
        Assert.Equal("1", Theory.JoinNumbersFromRange(1, 1));
        Assert.Equal("2345", Theory.JoinNumbersFromRange(2, 5));
        Assert.Equal("5678910", Theory.JoinNumbersFromRange(5, 10));
    }

    [Fact]
    public void CountCharsTests()
    {
        Assert.Equal(2, Theory.CountChars("hexlet", 'e'));
        Assert.Equal(2, Theory.CountChars("hexlet", 'E'));
        Assert.Equal(0, Theory.CountChars("", 'a'));
    }

    [Fact]
    public void ReverseTests()
    {
        Assert.Equal("telxeh", Theory.Reverse("hexlet"));
        Assert.Equal("", Theory.Reverse(""));
    }

    [Fact]
    public void FilterStringTests()
    {
        var str = "If I look back I am lost";
        Assert.Equal("f  look back  am lost", Theory.FilterString(str, 'i'));
        Assert.Equal("If I lk back I am lst", Theory.FilterString(str, 'o'));
    }

    [Fact]
    public void MakeItFunnyTests()
    {
        Assert.Equal("I NevEr LooK bAck", Theory.MakeItFunny("I never look back", 3));
    }

    [Fact]
    public void HasCharTests()
    {
        Assert.True(Theory.HasChar("Hexlet", 'H'));
        Assert.False(Theory.HasChar("Hexlet", 'h'));
        Assert.False(Theory.HasChar("Hexlet", 's'));
        Assert.False(Theory.HasChar("", 'A'));
    }
}

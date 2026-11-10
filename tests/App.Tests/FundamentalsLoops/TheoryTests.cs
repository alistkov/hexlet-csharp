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
}

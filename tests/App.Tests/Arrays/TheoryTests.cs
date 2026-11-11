using App.Arrays;

namespace App.Tests.Arrays;

public class TheoryTests
{
    [Fact]
    public void GetWeekendsTests()
    {
        Assert.Equal(["saturday", "sunday"], Theory.GetWeekends("long"));
        Assert.Equal(["saturday", "sunday"], Theory.GetWeekends());
        Assert.Equal(["saturday", "sunday"], Theory.GetWeekends("tiny"));
        Assert.Equal(["sat", "sun"], Theory.GetWeekends("short"));
    }

    [Fact]
    public void SwapTests()
    {
        var numbers1 = new int[] { 1 };
        Theory.Swap(numbers1);
        Assert.Equal(numbers1, new int[] { 1 });


        var numbers2 = new int[] { 1, 2, 3, 4, 5 };
        Theory.Swap(numbers2);
        Assert.Equal(numbers2, new int[] { 5, 2, 3, 4, 1 });

    }
}

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

    [Fact]
    public void AddPrefixTests()
    {
        var names = new string[] { "Smith", "Doe", "Jones" };
        var copy = names.Clone();

        Assert.Equal(["Mr. Smith", "Mr. Doe", "Mr. Jones"], Theory.AddPrefix(names, "Mr."));
        Assert.Equal(["Mrs. Smith", "Mrs. Doe", "Mrs. Jones"], Theory.AddPrefix(names, "Mrs."));
        Assert.Equal(copy, names);
    }

    [Fact]
    public void CalculateSumTests()
    {
        Assert.Equal(0, Theory.CalculateSum(new int[0]));

        Assert.Equal(48, Theory.CalculateSum(new int[] { 8, 9, 21, 19, 18, 22, 7 }));
        Assert.Equal(0, Theory.CalculateSum(new int[] { 2, 7, 5, 11, 1 }));
    }

    [Fact]
    public void MultTests()
    {
        Assert.Equal(24, Theory.Mult([2, 3, 4]));
        Assert.Equal(0, Theory.Mult([2, 3, 4, 0]));
        Assert.Equal(1, Theory.Mult([]));
    }

    [Fact]
    public void GetSameParityTests()
    {
        Assert.Equal([1, 3, 5], Theory.GetSameParity([1, 2, 3, 4, 5]));
        Assert.Equal([2, 2, 4, 6], Theory.GetSameParity([2, 2, 3, 4, 6]));
        Assert.Equal([], Theory.GetSameParity([]));
    }
}

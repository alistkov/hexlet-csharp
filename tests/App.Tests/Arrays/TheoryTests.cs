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
}

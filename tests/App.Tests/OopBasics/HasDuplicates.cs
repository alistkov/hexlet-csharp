using App.OopBasics;

namespace App.Tests.OopBasics;

public class HasDuplicates
{
    [Fact]
    public void NoDuplicates()
    {
        Assert.False(Theory.HasDuplicates(["csharp", "oop", "strings"]));
        Assert.False(Theory.HasDuplicates(["dotnet", "net"]));
        Assert.False(Theory.HasDuplicates(["oop"]));
        Assert.False(Theory.HasDuplicates([]));
    }
    
    [Fact]
    public void IgnoresCase()
    {
        Assert.True(Theory.HasDuplicates(["CSharp", "oop", "csharp"]));
    }

    [Fact]
    public void IgnoresSpaces()
    {
        Assert.True(Theory.HasDuplicates(["csharp", " csharp "]));
    }
}

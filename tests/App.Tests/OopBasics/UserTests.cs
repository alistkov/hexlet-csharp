using App.OopBasics;

namespace App.Tests.OopBasics;

public class UserTests
{
    [Fact]
    public void User()
    {
        var user = new User(1, "John Doe");
        Assert.Equal(1, user.Id);
        Assert.Equal("John Doe", user.Nickname);
    }

    [Fact]
    public void IsUsersSame()
    {
        var user = new User(1, "John Doe");
        var notSameUser = new User(2, "Sam Smith");
        var sameUser = new User(1, "Bob Jackson");
        
        Assert.True(user.IsSame(sameUser));
        Assert.False(user.IsSame(notSameUser));
        Assert.False(user.IsSame(null));
    }
}

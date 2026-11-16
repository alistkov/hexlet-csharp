using App.OopBasics;

namespace App.Tests.OopBasics;

public class UrlTests
{
    [Fact]
    public void Url()
    {
        var url = new Url("https://hexlet.io");

        Assert.Equal("https", url.Protocol);
        Assert.Equal("hexlet.io", url.Host);
        Assert.True(url.IsSecure);
        Assert.Equal("https://hexlet.io", url.Address);
    }

    [Fact]
    public void ChangeUrlProtocol()
    {
        var url = new Url("http://hexlet.io");

        Assert.Equal("http", url.Protocol);
        Assert.False(url.IsSecure);
        Assert.Equal("http://hexlet.io", url.Address);

        url.Protocol = "https";
        Assert.True(url.IsSecure);
        Assert.Equal("https://hexlet.io", url.Address);
    }
}

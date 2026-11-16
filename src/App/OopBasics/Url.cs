namespace App.OopBasics;

public class Url
{
    private string _protocol;
    private string _host;

    public Url(string url)
    {
        var parts = url.Split("://");
        _protocol = parts[0];
        _host = parts[1];
    }

    public string Protocol
    {
        get { return _protocol; }
        set { _protocol = value; }
    }

    public string Host
    {
        get { return _host; }
    }

    public bool IsSecure
    {
        get { return _protocol == "https"; }
    }

    public string Address
    {
        get { return $"{_protocol}://{_host}"; }
    }
}

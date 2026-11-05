namespace App.Fundamentals;

public class Theory
{
    public static void Run()
    {
        var name = "Brienna";
        var charArray = name.ToCharArray();
        Array.Reverse(charArray);
        name = new string(charArray);
        Console.WriteLine(name);
    }
}
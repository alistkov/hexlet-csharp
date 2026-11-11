namespace App.Arrays;

public class Theory
{
    public static string[] GetWeekends(string format = "long")
    {
        return format == "short"?["sat", "sun"] : ["saturday", "sunday"];
    }
}

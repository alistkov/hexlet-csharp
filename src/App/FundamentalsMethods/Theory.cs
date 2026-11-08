namespace App.FundamentalsMethods;

public class Theory
{
    public static string Methods()
    {
        var name = "Hodor";
        var who = name.ToUpper();
        var what = name.ToLower();
        return $"{who} says: \"{what}\"";
    }

    public static string MethodsParameters()
    {
        var one = "Naharis";
        var two = "Mormont";
        var three = "Sand";

        return $"{one[2]} {two[1]} {three[3]} {two[4]} {two[2]}";
    }
}

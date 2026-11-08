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

    public static string Properties()
    {
        var text = "Robert I Baratheon";
        return $"{text} has {text.Length} characters in his name";
    }

    public static string MethodsAsExpressions()
    {
        var text = "Never forget what you are, for surely the world will not";
        var result = $"First: {text[0]}\nLast: {text[text.Length - 1]}";
        Console.WriteLine(result);
        return result;
    }

    public static string StringImmutability(string email)
    {
        return email.Trim().ToLower();
    }

    public static string MethodsChain(string name)
    {
        var processed = name.Trim();
        var first = processed.Substring(0, 1).ToUpper();
        var rest = processed.Substring(1).ToLower();
        return $"{first}{rest}";
    }
}

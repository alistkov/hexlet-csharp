namespace App.FundamentalsConditionalStatements;

public class Theory
{
    public static bool IsPensioner(int age)
    {
        return age >= 60;
    }

    public static bool IsMister(string title)
    {
        return title == "Mister";
    }

    public static bool IsInternationalPhone(string phone)
    {
        return phone.StartsWith('+');
    }

    public static bool IsLannisterSoldier(string color, string? shield)
    {
        return (color == "red" && shield == null) || shield == "lion";
    }


    public static bool IsNotLannisterSoldier(string color, string? shield)
    {
        return !IsLannisterSoldier(color, shield);
    }

    public static bool IsNeutralSoldier(string armorColor, string shieldColor)
    {
        return armorColor != "red" && shieldColor == "black";
    }

    public static string GetSentenceTone(string sentence)
    {
        if (sentence == sentence.ToUpper())
        {
            return "scream";
        }
        return "normal";
    }

    public static string NormalizeUrl(string url)
    {
        if (url.StartsWith("https://"))
        {
            return url;
        }

        if (url.StartsWith("http://"))
        {
            return url.Replace("http://", "https://");
        }

        return "https://" + url;
    }

    public static string WhoIsThisHouseToStarks(string family)
    {
        string type;

        if (family == "Karstark" || family == "Tally")
        {
            type = "friend";
        }
        else if (family == "Lannister" || family == "Frey")
        {
            type = "enemy";
        }
        else
        {
            type = "neutral";
        }

        return type;
    }
}

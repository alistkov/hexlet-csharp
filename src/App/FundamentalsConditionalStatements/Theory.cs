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
}

namespace App.Arrays;

public class Theory
{
    public static string[] GetWeekends(string format = "long")
    {
        return format == "short"?["sat", "sun"] : ["saturday", "sunday"];
    }

    public static void Swap(int[] numbers)
    {
        if (numbers.Length < 2)
        {
            return;
        }

        var lastIndex = numbers.Length - 1;
        var firstElement = numbers[0];
        var lastElement = numbers[lastIndex];

        numbers[0] = lastElement;
        numbers[lastIndex] = firstElement;
    }

    public static string[] AddPrefix(string[] names, string prefix)
    {
        var result = new string[names.Length];

        for (var i = 0; i < names.Length; i += 1)
        {
            result[i] = $"{prefix} {names[i]}";
        }

        return result;
    }
}

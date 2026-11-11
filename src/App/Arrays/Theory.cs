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
}

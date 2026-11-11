namespace App.Arrays;

public class Theory
{
    public static string[] GetWeekends(string format = "long")
    {
        return format == "short" ? ["sat", "sun"] : ["saturday", "sunday"];
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

    public static int CalculateSum(int[] numbers)
    {
        var sum = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] % 3 == 0)
            {
                sum += numbers[i];
            }
        }

        return sum;
    }

    public static int Mult(int[] numbers)
    {
        var result = 1;

        foreach (var number in numbers)
        {
            result *= number;
        }

        return result;
    }

    public static int[] GetSameParity(int[] numbers)
    {
        if (numbers.Length == 0)
        {
            return [];
        }
        var data = new int[numbers.Length];
        var count = 0;

        var firstElementParity = numbers[0] % 2 == 0;

        foreach (var number in numbers)
        {
            var numberParity = number % 2 == 0;

            if (firstElementParity == numberParity)
            {
                data[count] = number;
                count += 1;
            }
        }

        var result = new int[count];
        Array.Copy(data, result, count);

        return result;
    }
}

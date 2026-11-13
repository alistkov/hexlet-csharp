using System.Text;

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

    public static int GetTotalAmount(string[] wallet, string currency)
    {
        var total = 0;

        foreach (var amount in wallet)
        {
            var amountCurrency = amount.Substring(0, 3);

            if (amountCurrency == currency)
            {
                var amountValue = int.Parse(amount.Substring(4));
                total += amountValue;
            }
        }

        return total;
    }

    public static string GetSuperSeriesWinner(int[][] scores)
    {
        var count = 0;

        foreach (var score in scores)
        {
            count += Math.Sign(score[0] - score[1]);
        }

        if (count == 0)
        {
            return "draw";
        }

        return count > 0 ? "canada" : "ussr";
    }

    public static string BuildDefinitionList(string[][] definitions)
    {
        if (definitions.Length == 0)
        {
            return "";
        }

        var result = new StringBuilder("<dl>");
        foreach (var definition in definitions)
        {
            result.Append("<dt>");
            result.Append(definition[0]);
            result.Append("</dt>");
            result.Append("<dd>");
            result.Append(definition[1]);
            result.Append("</dd>");
        }
        result.Append("</dl>");

        return result.ToString();
    }

    public static string MakeCensored(string sentence, string[] stopWords)
    {
        var replace = "$#%!";
        var words = sentence.Split(" ");
        var result = new StringBuilder();
        var separator = " ";

        foreach (var word in words)
        {
            var isInStopWords = Array.IndexOf(stopWords, word) != -1;
            var updatedWord = isInStopWords ? replace : word;
            result.Append(updatedWord);
            result.Append(separator);
        }

        return result.ToString().Trim();
    }

    public static int GetSameCount(int[] numbers1, int[] numbers2)
    {
        var count = 0;
        var seen = new HashSet<int>();

        foreach (var item in numbers1)
        {
            if (!seen.Contains(item) && Array.IndexOf(numbers2, item) >= 0)
            {
                seen.Add(item);
                count += 1;
            }
        }

        return count;
    }

    public static int CountUniqChars(string[] content)
    {
        char[] uniqueChars = [];

        foreach (var line in content)
        {
            uniqueChars = uniqueChars.Union(line).ToArray();
        }

        return uniqueChars.Length;
    }

    public static int[] BubbleSort(int[] numbers)
    {
        var steps = numbers.Length - 1;
        bool swaped;

        do
        {
            swaped = false;

            for (int i = 0; i < steps; i += 1)
            {
                if (numbers[i] > numbers[i + 1])
                {
                    (numbers[i], numbers[i + 1]) = (numbers[i + 1], numbers[i]);
                    swaped = true;
                }
            }

            steps -= 1;
        } while (swaped);

        return numbers;
    }

    public static int[] GetIntersectionOfSortedArrays(int[] data1, int[] data2)
    {
        var dataLength1 = data1.Length;
        var dataLength2 = data2.Length;

        var union = new int[Math.Min(dataLength1, dataLength2)];
        var count = 0;

        var index1 = 0;
        var index2 = 0;

        while (index1 < dataLength1 && index2 < dataLength2)
        {
            var first = data1[index1];
            var second = data2[index2];

            if (first == second)
            {
                if (count == 0 || union[count - 1] != data1[index1])
                {
                    union[count] = first;
                    count += 1;
                }
                index1 += 1;
                index2 += 1;
            }
            else if (first > second)
            {
                index2 += 1;
            }
            else if (second > first)
            {
                index1 += 1;
            }
        }

        var result = new int[count];
        Array.Copy(union, result, count);

        return result;
    }
}

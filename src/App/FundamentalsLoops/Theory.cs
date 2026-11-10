namespace App.FundamentalsLoops;

public class Theory
{
    public static void PrintNumbers(int numbers)
    {
        var i = numbers;

        while (i > 0)
        {
            Console.WriteLine(i);
            i -= 1;
        }
        Console.WriteLine("finished!");
    }
    
    public static int MultiplyNumbersFromRange(int begin, int end)
    {
        var result = 1;

        var index = begin;

        while (index <= end)
        {
            result *= index;
            index += 1;
        }

        return result;
    }

    public static String JoinNumbersFromRange(int start, int finish)
    {
        var result = "";
        var index = start;

        while (index <= finish)
        {
            result += index.ToString();
            index += 1;
        }

        return result;
    }

    public static int CountChars(string text, char symbol)
    {
        var count = 0;
        var index = 0;
        var lowerSymbol = char.ToLower(symbol);

        while (index < text.Length)
        {
            var currentSymbol = text[index];
            if (char.ToLower(currentSymbol) == lowerSymbol)
            {
                count += 1;
            }
            index += 1;
        }
        return count;
    }

    public static string Reverse(string word)
    {
        var reversedWord = "";
        var index = word.Length - 1;

        while (index >= 0)
        {
            reversedWord += word[index];
            index -= 1;
        }

        return reversedWord;
    }
}

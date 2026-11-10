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

    public static string FilterString(string text, char symbol)
    {
        var filteredString = "";
        var i = 0;
        var symbolToLower = char.ToLower(symbol);

        while (i < text.Length)
        {
            var currentSymbol = text[i];

            if (char.ToLower(currentSymbol) != symbolToLower)
            {
                filteredString += currentSymbol;
            }

            i += 1;
        }

        return filteredString;
    }

    public static string MakeItFunny(string text, int index)
    {
        var result = "";
        var i = 0;

        while (i < text.Length)
        {
            if ((i + 1) % index == 0)
            {
                result += char.ToUpper(text[i]);
            }
            else
            {
                result += text[i];
            }
            
            i += 1;
        }

        return result;
    }

    public static bool HasChar(string str, char ch)
    {
        var i = 0;
        while (i < str.Length)
        {
            if (ch == str[i])
            {
                return true;
            }

            i += 1;
        }
        return false;
    }
    
    public static string Encrypt(string str)
    {
        // BEGIN (write your solution here)
        var result = "";
        
        for (int i = 0; i < str.Length; i += 2)
        {
            var currentChar = str[i];

            if (i  == str.Length - 1)
            {
                result += currentChar;
            }
            else
            {
                var nextChar = str[i + 1];
                result = result + nextChar + currentChar;
            }

        }

        return result;
        // END
    }
}

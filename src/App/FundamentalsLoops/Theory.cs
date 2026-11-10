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
}

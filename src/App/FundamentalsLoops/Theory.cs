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
}

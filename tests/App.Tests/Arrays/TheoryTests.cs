using App.Arrays;

namespace App.Tests.Arrays;

public class TheoryTests
{
    [Fact]
    public void GetWeekendsTests()
    {
        Assert.Equal(["saturday", "sunday"], Theory.GetWeekends("long"));
        Assert.Equal(["saturday", "sunday"], Theory.GetWeekends());
        Assert.Equal(["saturday", "sunday"], Theory.GetWeekends("tiny"));
        Assert.Equal(["sat", "sun"], Theory.GetWeekends("short"));
    }

    [Fact]
    public void SwapTests()
    {
        var numbers1 = new int[] { 1 };
        Theory.Swap(numbers1);
        Assert.Equal(numbers1, new int[] { 1 });

        var numbers2 = new int[] { 1, 2, 3, 4, 5 };
        Theory.Swap(numbers2);
        Assert.Equal(numbers2, new int[] { 5, 2, 3, 4, 1 });
    }

    [Fact]
    public void AddPrefixTests()
    {
        var names = new string[] { "Smith", "Doe", "Jones" };
        var copy = names.Clone();

        Assert.Equal(["Mr. Smith", "Mr. Doe", "Mr. Jones"], Theory.AddPrefix(names, "Mr."));
        Assert.Equal(["Mrs. Smith", "Mrs. Doe", "Mrs. Jones"], Theory.AddPrefix(names, "Mrs."));
        Assert.Equal(copy, names);
    }

    [Fact]
    public void CalculateSumTests()
    {
        Assert.Equal(0, Theory.CalculateSum([]));

        Assert.Equal(48, Theory.CalculateSum([8, 9, 21, 19, 18, 22, 7]));
        Assert.Equal(0, Theory.CalculateSum([2, 7, 5, 11, 1]));
    }

    [Fact]
    public void MultTests()
    {
        Assert.Equal(24, Theory.Mult([2, 3, 4]));
        Assert.Equal(0, Theory.Mult([2, 3, 4, 0]));
        Assert.Equal(1, Theory.Mult([]));
    }

    [Fact]
    public void GetSameParityTests()
    {
        Assert.Equal([1, 3, 5], Theory.GetSameParity([1, 2, 3, 4, 5]));
        Assert.Equal([2, 2, 4, 6], Theory.GetSameParity([2, 2, 3, 4, 6]));
        Assert.Equal([], Theory.GetSameParity([]));
    }

    [Fact]
    public void GetTotalAmountTests()
    {
        var wallet = new string[] { "usd 10", "eur 20", "usd 5", "usd 1", "eur 5" };

        Assert.Equal(16, Theory.GetTotalAmount(wallet, "usd"));
        Assert.Equal(25, Theory.GetTotalAmount(wallet, "eur"));
        Assert.Equal(0, Theory.GetTotalAmount(wallet, "rsd"));
    }

    [Fact]
    public void GetSuperSeriesWinnerTests()
    {
        var score1 = new int[][] { [3, 7], [4, 1], [4, 4], [3, 5], [4, 5], [3, 2], [4, 3], [6, 5] };
        Assert.Equal("canada", Theory.GetSuperSeriesWinner(score1));

        var score2 = new int[][] { [3, 7], [4, 1], [4, 4], [3, 5], [4, 5], [3, 4], [4, 3], [6, 5] };
        Assert.Equal("ussr", Theory.GetSuperSeriesWinner(score2));

        var score3 = new int[][] { [3, 7], [4, 1], [4, 4], [3, 5], [4, 4], [3, 4], [4, 3], [6, 5] };
        Assert.Equal("draw", Theory.GetSuperSeriesWinner(score3));
    }

    [Fact]
    public void BuildDefinitionListTests()
    {
        string[][] definitions =
        [
            ["Блямба", "Выпуклость, утолщение на поверхности чего-либо"],
            ["Бобр", "Животное из отряда грызунов"],
        ];
        var expected =
            "<dl><dt>Блямба</dt><dd>Выпуклость, утолщение на поверхности чего-либо</dd><dt>Бобр</dt><dd>Животное из отряда грызунов</dd></dl>";

        Assert.Equal(expected, Theory.BuildDefinitionList(definitions));

        Assert.Equal(string.Empty, Theory.BuildDefinitionList([]));
    }

    [Fact]
    public void MakeCensoredTests()
    {
        var text = "When you play the game of thrones, you win or you die";
        string[] stopWords = ["die", "play"];
        var expected = "When you $#%! the game of thrones, you win or you $#%!";

        Assert.Equal(expected, Theory.MakeCensored(text, stopWords));

        var text1 = "the game of thrones";
        Assert.Equal(text1, Theory.MakeCensored(text1, []));
        Assert.Equal(text1, Theory.MakeCensored(text1, ["die"]));
    }

    [Fact]
    public void GetSameCountTests()
    {
        Assert.Equal(3, Theory.GetSameCount([1, 3, 2, 2], [3, 1, 1, 2, 5]));
        Assert.Equal(1, Theory.GetSameCount([1, 4, 4], [4, 8, 4]));
        Assert.Equal(2, Theory.GetSameCount([1, 10, 3], [10, 100, 35, 1]));
        Assert.Equal(0, Theory.GetSameCount([], []));
        Assert.Equal(1, Theory.GetSameCount([0, 1], [0]));
    }

    [Fact]
    public void CountUniqCharsTests()
    {
        Assert.Equal(3, Theory.CountUniqChars(["yyab"]));
        Assert.Equal(13, Theory.CountUniqChars(["You know nothing Jon Snow"]));
        Assert.Equal(4, Theory.CountUniqChars(["111yya!", "aaa"]));
        Assert.Equal(6, Theory.CountUniqChars(["cat", "act", "dog"]));
        Assert.Equal(0, Theory.CountUniqChars([]));
    }
}

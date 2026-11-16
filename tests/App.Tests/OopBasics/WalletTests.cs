using App.OopBasics;

namespace App.Tests.OopBasics;

public class WalletTests
{
    [Fact]
    public void Wallet()
    {
        var wallet = new Wallet(100);

        Assert.Equal(100, wallet.Balance);

        wallet.Withdraw(30);
        Assert.Equal(70, wallet.Balance);
    }

    [Fact]
    public void WithdrawlWithZeroAmountThrowsArgumentException()
    {
        var wallet = new Wallet(100);

        var exception = Assert.Throws<ArgumentException>(() => wallet.Withdraw(0));
        Assert.Equal("Сумма должна быть больше нуля: 0", exception.Message);
    }

    [Fact]
    public void WithdrawlWithAmountMoreThanBalanceThrowsArgumentException()
    {
        var wallet = new Wallet(10);

        var exception = Assert.Throws<ArgumentException>(() => wallet.Withdraw(30));
        Assert.Equal("Недостаточно средств: 30", exception.Message);
    }
}

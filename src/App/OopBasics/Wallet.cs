namespace App.OopBasics;

public class Wallet(int balance)
{
    public int Balance { get; private set; } = balance;

    public void Withdraw(int amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentException($"Сумма должна быть больше нуля: {amount}");
        }

        if (amount > Balance)
        {
            throw new ArgumentException($"Недостаточно средств: {amount}");
        }

        Balance -= amount;
    }
}

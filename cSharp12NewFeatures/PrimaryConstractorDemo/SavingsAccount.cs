﻿namespace PrimaryConstractorDemo;

public class SavingsAccount: BankAccount
{
    private readonly decimal _depositedAmount;
    public SavingsAccount(string accountNumber, string ownerName, decimal depositedAmount): base(accountNumber, ownerName)
    {
        _depositedAmount = depositedAmount;
    }

    public void Deposit()
    {
        if (_depositedAmount >= 1000)
        {
            throw new Exception("Deposit is not allowed more than 1000");
        }
        Console.WriteLine($"{OwnerName} is successfully deposited {_depositedAmount}. Account Number: {AccountNumber}");
    }
}


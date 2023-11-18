namespace PrimaryConstractorDemo;

public class BankAccount(string accountNumber, string ownerName)
{
    public string AccountNumber { get; } = IsValidAccountNumber(accountNumber) ? accountNumber : throw new ArgumentException("Invalid account number");

    public string OwnerName { get; } = string.IsNullOrEmpty(ownerName) ? throw new ArgumentException("Account number is required") : ownerName;

    public static bool IsValidAccountNumber(string accountNumber) => accountNumber?.Length <= 10;
}

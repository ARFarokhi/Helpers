namespace WebApi.Model;

public class BankAccount(string accountID, string owner)
{
    public string AccountID { get; } = accountID;
    public string Owner { get; } = owner;
    public override string ToString() => $"Account ID: {AccountID}, Owner: {Owner}";
}
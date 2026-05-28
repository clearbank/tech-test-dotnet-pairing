var alice = new BankAccount("Alice", 100.00m);
var bob = new BankAccount("Bob", 50.00m);

alice.Deposit(25.00m);
Console.WriteLine($"{alice.Name}: £{alice.Balance}");

bool success = bob.Withdraw(75.00m);
Console.WriteLine($"Withdrawal successful: {success}");
Console.WriteLine($"{bob.Name}: £{bob.Balance}");

alice.Withdraw(30.00m);
Console.WriteLine($"{alice.Name}: £{alice.Balance}");

class BankAccount
{
    public string Name { get; }
    public decimal Balance { get; private set; }

    public BankAccount(string name, decimal openingBalance)
    {
        Name = name;
        Balance = openingBalance;
    }

    public void Deposit(decimal amount)
    {
        Balance += amount;
    }

    public bool Withdraw(decimal amount)
    {
        Balance -= amount;
        return Balance >= 0;
    }
}

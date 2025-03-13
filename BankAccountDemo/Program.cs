using BankAccount;

BankAccount.BankAccount ba = new BankAccount.BankAccount("Joseph", 100);
ba.Deposit(40);
Console.WriteLine($"Account {ba.AccountHolder} has a balance of {ba.Balance}");
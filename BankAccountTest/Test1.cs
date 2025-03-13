using BankAccount;

namespace BankAccountTest;

[TestClass]
public sealed class Test1
{
    [TestMethod]
    public void TestInitialBalance()
    {
        var account = new BankAccount.BankAccount("Joseph", 100);
        var balance = account.Balance;
        Assert.AreEqual(100, balance);
    }

    [TestMethod]
    public void TestDeposit()
    {
        var account = new BankAccount.BankAccount("Joseph", 100);
        account.Deposit(50);
        var balance = account.Balance;
        Assert.AreEqual(150, balance);
    }

    [TestMethod]
    public void TestAccountHolder()
    {
        var account = new BankAccount.BankAccount("Joseph", 100);
        var accountHolder = account.AccountHolder;
        Assert.AreEqual("Joseph", accountHolder);
    }

    [TestMethod]
    public void TestWithdrawal()
    {
        var account = new BankAccount.BankAccount("Joseph", 100);
        account.Withdraw(50);
        var balance = account.Balance;
        Assert.AreEqual(50, balance);
    }

    [TestMethod]
    public void TestNegativeBalance()
    {
        var account = new BankAccount.BankAccount("Joseph", -100);
        var balance = account.Balance;
        Assert.AreEqual(-100, balance);
    }

    [TestMethod]
    public void TestOverdraftProtection()
    {
        var account = new BankAccount.BankAccount("Joseph", 100);
        account.Withdraw(150);
        var balance = account.Balance;
        Assert.AreEqual(100, balance);
    }
}

using Oogarts.Domain.Accounts;

namespace Tests.Domain;

public class AccountTest
{
    [Fact]
    public void NewAccount_CreatedCorrectly()
    {
        Account account = new Account("Test1", "Test2");
        Assert.NotNull(account);
        Assert.Equal("Test1", account.Username);
        Assert.Equal("Test2", account.Password);
    }

    [Fact]
    public void NewAccount_UsernameIncorrect()
    {
        foreach(string username in new[] { "", " ", "   ", "a", "Uname with spaces", 
                        "UsernameThatIsTooLongToBeAValidUsernameAndShouldThereforeDefinetlyMakeThisTestFail"})
        {
            Assert.Throws<ArgumentException>(() => _ = new Account(username, "Test"));
        }
    }
    [Fact]
    public void NewAccount_UsernameIsNull()
    {
        Assert.Throws<ArgumentNullException>(() => _ = new Account(null, "Test"));
    }

    [Fact]
    public void NewAccount_PasswordIncorrect()
    {
        foreach (string password in new[] { "", " ", "   ", "a" })
        {
            Assert.Throws<ArgumentException>(() => _ = new Account("Test", password));
        }
    }
    [Fact]
    public void NewAccount_PasswordIsNull()
    {
        Assert.Throws<ArgumentNullException>(() => _ = new Account("Test", null));
    }
}

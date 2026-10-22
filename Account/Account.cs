public class Account
{
    public int AccountNumber {get;set;}
    public string? AccountHolderName {get;set;}
    public int CurrentBalance {get;set;}
    public Account()
    {
        this.AccountNumber = 1001;
        this.AccountHolderName = "Example Name";
        this.CurrentBalance =  5000;
    }
}
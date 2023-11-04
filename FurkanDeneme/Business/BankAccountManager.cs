using FurkanDeneme.Data;
using FurkanDeneme.Models;

namespace FurkanDeneme.Business;

public class BankAccountManager : IBankAccountService
{
    private readonly IBankAccountData _accountData;

    public BankAccountManager()
    {
        _accountData = new BankAccountData();
    }

    public void Deposit(string iban, double money)
    {
        var account = _accountData.GetAccountByIban(iban);
        if (account.CustomerType==CustomerType.Student)
        {
            account.Budget += money * 0.03;
        }

        account.Budget += money;
    }

    public void WithDrawMoney(string iban, double money)
    {
        
    }
}
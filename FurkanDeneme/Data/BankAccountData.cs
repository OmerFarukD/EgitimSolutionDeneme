using FurkanDeneme.Models;

namespace FurkanDeneme.Data;

public class BankAccountData : IBankAccountData
{

    private readonly List<BankAccount> _bankAccounts;

    public BankAccountData()
    {
        _bankAccounts = new List<BankAccount>()
        {
            new BankAccount()
            {
                Budget = 2000,
                CustomerName = "Furkan Oğuz",
                CustomerType = CustomerType.Individual,
                Iban = "101102103"
            },
            new BankAccount()
            {
                Budget = 4000,
                CustomerName = "Oğuz Furkan",
                CustomerType = CustomerType.Student,
                Iban = "201202203"
            }
        };
    }
    public List<BankAccount> GetAccounts()
    {
        return _bankAccounts;
    }

    public BankAccount GetAccountByIban(string iban)
    {
        return _bankAccounts.SingleOrDefault(x => x.Iban == iban);
    }
}
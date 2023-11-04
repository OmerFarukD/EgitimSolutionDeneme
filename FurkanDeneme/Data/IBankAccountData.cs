using FurkanDeneme.Models;

namespace FurkanDeneme.Data;

public interface IBankAccountData
{
    List<BankAccount> GetAccounts();
    BankAccount GetAccountByIban(string iban);
}
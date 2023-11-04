namespace FurkanDeneme.Business;

public interface IBankAccountService
{
    void Deposit(string iban, double money);
    void WithDrawMoney(string iban, double money);
}
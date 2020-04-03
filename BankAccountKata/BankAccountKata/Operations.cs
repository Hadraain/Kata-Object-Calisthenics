using System;
namespace BankAccountKata
{
    public class Operations
    {
        private Account _account;
        
        public Operations(Account account)
        {
            _account = account;
        }

        public void deposit(double deposit)
        {
            _account.updateSold(_account.getSold() + deposit);
        }

        public void withdrawal(double withdraw)
        {

        }
    }
}

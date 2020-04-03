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

        public bool withdrawal(double withdraw)
        {
            var newSold = _account.getSold() - withdraw;
            
            if (newSold >= 0)
            {
                _account.updateSold(newSold);
                return true; 
            }

            return false;
        }
    }
}

using NFluent;
using NUnit.Framework;

namespace BankAccountKata.Test
{
    public class BankAccountTest
    {
        [Test]
        public void MyFirstTest()
        {
            Check.That(true).IsTrue();
        }
        
        [Test]
        public void depositTest()
        {
            var account = new Account();
            var operation = new Operations(account);

            operation.deposit(100);

            Check.That(account.sold).Equals(100);
        }
    }
}

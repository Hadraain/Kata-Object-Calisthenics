using NFluent;
using NUnit.Framework;
using BankAccountKata;

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

            Check.That(account.getSold()).Equals(100.0);
        }

        [Test]
        public void withdrawalOkTest()
        {
            var account = new Account();
            var operation = new Operations(account);

            operation.deposit(100);
            var operationRuslt = operation.withdrawal(50);

            Check.That(operationRuslt).IsTrue();
            Check.That(account.getSold()).Equals(50.0);
        }

        [Test]
        public void withdrawalErrorTest()
        {
            var account = new Account();
            var operation = new Operations(account);

            operation.deposit(100);
            var operationRuslt = operation.withdrawal(1000);

            Check.That(operationRuslt).IsFalse();
            Check.That(account.getSold()).Equals(100.0);
        }
    }
}

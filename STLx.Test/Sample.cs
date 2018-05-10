using NUnit.Framework;

namespace STLx.Test
{
    public class Account
    {
        private decimal balance;

        public void Deposit(decimal amount)
        {
            balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            balance -= amount;
        }

        public void TransferFunds(Account destination, decimal amount)
        {
        }

        public decimal Balance
        {
            get { return balance; }
        }
    }


    [TestFixture]
    public class Sample
    {
        [Test]
        public void TransferFunds()
        {
            Account source = new Account();
            source.Deposit(200m);

            Account destination = new Account();
            destination.Deposit(150m);

            source.TransferFunds(destination, 100m);

            Assert.AreEqual(150m, destination.Balance);
            Assert.AreEqual(200m, source.Balance);
        }
    }
}

namespace hw
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account account1 = new Account(1000, 5000);
            account1.Withdraw(6000);

            VipAccount account2 = new VipAccount(2000, 10000);
            account2.Withdraw(12000);

        }
    }

    class Account
    {
        protected int accountNumber { get; set; }
        protected double balance { get; set; }

        public Account(int accountNumber, double balance)
        {
            this.accountNumber = accountNumber;
            this.balance = balance;
        }
        public virtual void Withdraw(double amount)
        {
            if (balance - amount >= 0)
            {
                balance -= amount;

            }
            else
            {
                Console.WriteLine("Not enough money");
            }

        }

    }

}
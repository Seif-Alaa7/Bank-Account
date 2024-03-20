namespace ConsoleApp1
{
    public class Account
    {
        public string name;
        public double balance;

        public Account(string name = "Unnamed Account", double balance = 0.0)
        {
            this.name = name;
            this.balance = balance;
        }

        public virtual bool Deposit(double amount)
        {
            if (amount < 0)
                return false;
            else
            {
                balance += amount;
                return true;
            }
        }
        public virtual bool Withdraw(double amount)
        {
            if (balance - amount >= 0 && amount>0)
            {
                balance -= amount;
                return true;
            }
            else
            {
                return false;
            }
        }
        public double GetBalance()
        {
            return balance;
        }

        public override string ToString()
        {
            return $"[Account: {name}: {balance}]";
        }
        public static Account operator +(Account account1, Account account2)
        {
            string CombinedName = ($"{account1.name} + {account2.name}");
            double CombinedBalance = (account1.balance + account2.balance);
            return new Account(CombinedName, CombinedBalance);
        }
    }
}

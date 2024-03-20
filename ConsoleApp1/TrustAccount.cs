namespace ConsoleApp1
{
    public class TrustAccount : SavingsAccount
    {
        private const double bonusThreshold = 5000.00;
        private const double bonus = 50.00;
        private const int maxYear = 3;
        private const double maxPercentage = 0.20;
        private int withdrawalsThisYear;

        public TrustAccount(string name = "Unnamed Account", double balance = 0.0, double interestRate = 0.0)
            : base(name, balance, interestRate)
        {
            withdrawalsThisYear = 0;
        }

        public override bool Deposit(double amount)
        {
            if (base.Deposit(amount))
            {
                if (amount >= bonusThreshold)
                    balance += bonus;
                return true;
            }
            return false;
        }

        public override bool Withdraw(double amount)
        {
            if (withdrawalsThisYear < maxYear && amount <= balance * maxPercentage)
            {
                withdrawalsThisYear++;
                return base.Withdraw(amount);
            }
            return false;
        }

        public override string ToString()
        {
            return $"[Trust Account: {name}, Balance: {balance}]";
        }

        /*public class TrustAccount : Account
        {
            *//*private double interestRate;
            private const double bonus = 50.00;
            private const double bonusThreshold = 5000.00;

            public TrustAccount(string name = "Unnamed Account", double balance = 0.0, double interestRate = 0.0)
                : base(name, balance)
            {
                this.interestRate = interestRate;
            }
            public override bool Deposit(double amount)
            {
                if (amount < 0)
                    return false;
                else
                {
                    balance += amount;
                }
                if (amount >= bonusThreshold)
                {
                    balance += bonus;
                }
                return true;
            }

            public override string ToString()
            {
                return $"[Trust Account: {name}: {balance}]";
            }*//**/
    }
}

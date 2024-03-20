namespace ConsoleApp1
{
    internal class CheckingAccount : Account
    {
        const double withdrawalFee = 1.50;

        public CheckingAccount(string name = "Unnamed Account", double balance = 0.0): base(name, balance)
        {
        }
        public override bool Withdraw(double amount)
        {
            double total = amount + withdrawalFee;
            if (balance - total >= 0 && total > 0)
            {
                balance -= total;
                return true;
            }
            else
            {
                return false;
            }
        }
        public override string ToString()
        {
            return ($"[Checking Account: {name}: {balance}]");
        }
    }
}

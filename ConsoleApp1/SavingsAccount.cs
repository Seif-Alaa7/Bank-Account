using System.Xml.Linq;

namespace ConsoleApp1
{
    public class SavingsAccount : Account
    {
        private double interestRate;
        public SavingsAccount(string name = "Unnamed Account", double balance = 0.0, double interestRate = 0.0): base(name, balance)
        {
            this.interestRate = interestRate;
        }
        public void AddInterest()
        {
            balance += balance * interestRate;
        }
        public override string ToString()
        {
            return ($"[Savings Account: {name}: {balance}]");
        }
    }
}

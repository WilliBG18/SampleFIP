using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleFIP
{
    public abstract class Portfolio
    {
        public abstract int AcctBalance(int balance);
        public abstract int GetSalary(int salary);
        public abstract double PercInvest(int salary, double percent);
    }
    public class ClientAcct : Portfolio
    {
        public override int AcctBalance(int balance)
        {
            return balance;
        }

        public override int GetSalary(int salary)
        {
            return salary;
        }

        public override double PercInvest(int salary, double percent)
        {
            double amount = salary * percent;
            return amount;
        }
    }
}

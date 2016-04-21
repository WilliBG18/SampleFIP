using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleFIP
{
    public abstract class Portfolio
    {
        public abstract void AcctBalance(int balance);
    }
    public class ClientAcct : Portfolio
    {
        public override void AcctBalance(int balance)
        {

        }
    }
}

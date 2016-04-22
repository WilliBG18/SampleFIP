using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleFIP
{
    public abstract class StkPortfolio
    {
        public abstract int RandVal(double minPerc, double maxPerc);
        public abstract double ShowDayChange(double dayChange, double percChange);
        public abstract double ShowTtlChange(double ttlChange, double dayChange);
        public abstract double CurrStockVal(double stockVal);
    }
    public class Google : StkPortfolio
    {
        public override int RandVal(double minPerc, double maxPerc)
        {
            throw new NotImplementedException();
        }
        public override double ShowDayChange(double dayChange, double percChange)
        {
            throw new NotImplementedException();
        }
        public override double ShowTtlChange(double ttlChange, double dayChange)
        {
            throw new NotImplementedException();
        }
        public override double CurrStockVal(double currVal)
        {
            throw new NotImplementedException();
        }
    }
    public class Gold : StkPortfolio
    {
        public override int RandVal(double minPerc, double maxPerc)
        {
            throw new NotImplementedException();
        }
        public override double ShowDayChange(double dayChange, double percChange)
        {
            throw new NotImplementedException();
        }
        public override double ShowTtlChange(double ttlChange, double dayChange)
        {
            throw new NotImplementedException();
        }
        public override double CurrStockVal(double currVal)
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleFIP
{
    public abstract class StkPortfolio
    {
        public abstract double RandStkVal(double minPerc, double maxPerc);
        public abstract int    RandVal();
        public abstract double[] ShowDayChange(double baseStk);
        public abstract double[] ShowTtlChange(double baseStk);
        public abstract string StockName();
        public abstract double stkVal();
    }
    public class Google : StkPortfolio
    {
        string stkName = "GOOGL";
        double googleStk = 250.00;
        double ttlChange = 0;
        double ttlStk = 0;

        StkPortfolio google;

        public override double RandStkVal(double minPerc, double maxPerc)
        {
            Random random = new Random();
            double percent = random.NextDouble() * (maxPerc - minPerc) + minPerc;
            percent = Math.Round(percent, 2);
            return percent;
        }
        public override int RandVal()
        {
            int sign;
            Random random = new Random();
            int signPercent = random.Next(0, 2);
            if (signPercent == 0)
            {
                sign = -1;
            }
            else
                sign = 1;
            return sign;
        }
        public override double[] ShowDayChange(double baseStk)
        {
            google = new Google();
            double amntChange;
            double dayChange;
            baseStk = google.stkVal();
            double percChange = google.RandStkVal(.01, .05);
            double sign = google.RandVal();
            amntChange = baseStk * percChange * sign;
            dayChange = amntChange + baseStk;
            double[] values = new double[2] { amntChange, dayChange };
            return values;
        }
        public override double[] ShowTtlChange(double baseStk)
        {
            google = new Google();
            baseStk = google.stkVal();
            double[] dayChange = google.ShowDayChange(google.stkVal());
            double currVal = dayChange[0];
            ttlChange = currVal + ttlChange;
            ttlStk = baseStk + ttlChange;
            double[] values = new double[2] { ttlChange, ttlStk };
            return values;
        }
        public override string StockName()
        {
            string name = stkName;
            return name;
        }
        public override double stkVal()
        {
            double baseStk = googleStk;
            return baseStk;
        }

    }
    //public class Gold : StkPortfolio
    //{
    //    public override double RandVal(double minPerc, double maxPerc)
    //    {
    //        Random random = new Random();
    //        return random.NextDouble() * (maxPerc - minPerc) + minPerc;

    //    }
    //    public override double ShowDayChange(double dayChange, double percChange)
    //    {
    //        throw new NotImplementedException();
    //    }
    //    public override double ShowTtlChange(double ttlChange, double origVal)
    //    {
    //        throw new NotImplementedException();
    //    }
    //    public override double CurrStockVal(double currVal)
    //    {
    //        throw new NotImplementedException();
    //    }
    //}
}

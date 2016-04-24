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
        public abstract int    RandVal(int minPerc, int maxPerc);
        public abstract double[] ShowDayChange(double baseStk, double percChange, int sign);
        public abstract double[] ShowTtlChange(double baseStk, double[] dayChange);
        public abstract double CurrStockVal(double stockVal);
    }
    public class Google : StkPortfolio
    {
        double googleStk = 250.00;
        StkPortfolio google;

        public override double RandStkVal(double minPerc, double maxPerc)
        {
            Random random = new Random();
            double percent = random.NextDouble() * (maxPerc - minPerc) + minPerc;
            percent = Math.Round(percent, 2);
            return percent;
        }
        public override int RandVal(int minPerc, int maxPerc)
        {
            int sign;
            Random random = new Random();
            int signPercent = random.Next() * (maxPerc - minPerc) + minPerc;
            if (signPercent == 0)
            {
                sign = -1;
            }
            else
                sign = 1;
            return sign;
        }
        public override double[] ShowDayChange(double baseStk, double percChange, int sign)
        {
            google = new Google();
            double amntChange;
            double dayChange;
            baseStk = google.CurrStockVal(googleStk);
            percChange = google.RandStkVal(.01, .05);
            sign = google.RandVal(0, 1);
            amntChange = baseStk * percChange * sign;
            dayChange = Math.Round(amntChange + baseStk, 2);
            double[] values = new double[2] { amntChange, dayChange };
            return values;
        }
        public override double[] ShowTtlChange(double baseStk, double[] dayChange)
        {
            google = new Google();
            baseStk = google.CurrStockVal(googleStk);
            dayChange = google.ShowDayChange(google.CurrStockVal(googleStk), google.RandStkVal(.01, .05), google.RandVal(0, 1));
            double currVal = baseStk + dayChange[0];
            double ttlChange = currVal - baseStk;
            double ttlStk = baseStk + ttlChange;
            double[] values = new double[2] { ttlChange, ttlStk };
            return values;
        }
        public override double CurrStockVal(double currVal)
        {
            currVal = googleStk;
            return currVal;
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap02
{
    public class Accumulator
    {
        private double m; 
        private double s; 
        private int N;   

        public void AddDataValue(double x)
        {
            N++;
            s += (N - 1.0) / N * (x - m) * (x - m);
            m += (x - m) / N;
        }

        public double Mean()
        {
            return m;
        }

        public double Var()
        {
            return (N > 1) ? s / (N - 1) : 0; 
        }

        public double StdDev()
        {
            return Math.Sqrt(Var());
        }
    }
}

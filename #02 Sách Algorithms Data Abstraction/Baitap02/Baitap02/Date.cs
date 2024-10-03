using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap02
{
    public class Date
    {
        private int month;
        private int day;
        private int year;

        public Date(string date)
        {
            string[] fields = date.Split('/');
            month = int.Parse(fields[0]);
            day = int.Parse(fields[1]);
            year = int.Parse(fields[2]);
        }

        public override string ToString()
        {
            return $"{month}/{day}/{year}";
        }
    }
}

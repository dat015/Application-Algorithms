using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap02
{
    public class Transaction
    {
        private string customer;
        private Date date;
        private double amount;

        public Transaction(string transaction)
        {
            string[] fields = transaction.Split(' ');

            customer = fields[0];
            date = new Date(fields[1]); 
            amount = double.Parse(fields[2]);
        }

        public override string ToString()
        {
            return $"{customer} {date} {amount}";
        }
    }
}

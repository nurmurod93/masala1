using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace masala1
{
    public class Pul
    {
        

        public decimal Amount { get; set; }
        public string Currency { get; set; }

        public Pul(decimal amount)
        {
            Amount = amount;
            Currency = "UZS";
        }
        public delegate void PulDelegate(Pul amount);
    }
}

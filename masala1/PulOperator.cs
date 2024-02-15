using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace masala1
{
    public class PulOperator
    {
        public void UzsUsd(Pul pul)
        {
            pul.Currency = "USD";
            pul.Amount *= 12360;
        }
        public void Send(Pul pul, string bank, Pul.PulDelegate pulDelegate)
        {
            if(pulDelegate.Target != null)
            {
                pulDelegate(pul);
                Console.WriteLine(pul.Amount.ToString("0.00") + " " + pul.Currency + "\t pul summasi" + "o'tkazma muvaffaqiyatli bajarildi" + bank);
            }
        }
    }
}

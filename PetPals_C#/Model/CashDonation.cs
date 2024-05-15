using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetPals_C_.Model
{
    internal class CashDonation 
    {
        public string DonorName { get; set; }
        public decimal Amount { get; set; }

        public DateTime Date { get; set; }
        public CashDonation()
        {
            
        }
        public CashDonation(string DonorName,decimal Amount,DateTime Date)
        {
            
        }
    }
}

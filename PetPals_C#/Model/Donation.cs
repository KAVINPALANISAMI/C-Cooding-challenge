using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetPals_C_.Model
{
    internal  abstract class  Donation
    {
        public  string DonorName {  get; set; }
        public decimal Amount {  get; set; }
       

        public Donation()
        {
            
        }

        public Donation(string name,decimal amount)
        {
            DonorName = name;
            Amount = amount;
            
        }

        public abstract int RecordDonation();
    }
}

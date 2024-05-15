using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetPals_C_.Exceptions
{
    internal class InvalidPetAgeHandling :ApplicationException
    {
        public InvalidPetAgeHandling(string msg):base(msg) { }
    }
}

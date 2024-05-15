using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetPals_C_.Service.Interface
{
    internal interface IPetShelterService
    {
         public void ListAvailablePets();
        public void AddPet();
        public void RemovePet();
    }
}

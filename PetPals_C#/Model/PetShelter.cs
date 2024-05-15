using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetPals_C_.Model
{
    internal class PetShelter
    {
       public  int ShelterID {  get; set; }
        public string Name { get; set; }
        public string Location { get; set; }

        public Pet Pet { get; set; }

        public PetShelter()
        {
            Pet = new Pet();
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetPals_C_.Model
{
    internal class Pet
    {
        public int PetId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public  string Breed { get; set; }
        public int AvailableForAdoption { get; set; }
        public string Type { get; set; }

        public Pet()
        {
            
        }
        public Pet(string name,int age,string breed)
        {
            Name = name;
            Age = age;
            Breed = breed;
            
        }
    }
}

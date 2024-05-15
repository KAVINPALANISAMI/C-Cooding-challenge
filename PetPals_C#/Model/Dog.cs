using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetPals_C_.Model
{
    internal class Dog : Pet
    {
        public string DogBreed { get; set; }
        public Dog() 
        { 

       
        }
        public Dog(string name, int age, string breed,string dogbreed):base(name,age,breed)
        {  

            DogBreed = dogbreed;
        }
        public override string ToString()
        {
            return $"petId::{PetId} Dog name{Name}::Age:{Age}\tBreed::{Breed}\t Dog Breed{DogBreed} ";
        }

    }
}

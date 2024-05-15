using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetPals_C_.Model
{
    internal class Cat:Pet
    {
        public string CatColor { get; set; }
        public Cat() 
        { }

        public Cat(string name, int age, string breed, string catcolour) : base(name, age, breed)
        {

            CatColor = catcolour;
        }
        public override string ToString()
        {
            return $"petId::{PetId} Cat name{Name}::Age:{Age}\tBreed::{Breed}\tCat Colour{CatColor} ";
        }


    }
}

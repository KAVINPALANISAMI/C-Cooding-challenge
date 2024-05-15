using PetPals_C_.Model;
using PetPals_C_.Repository;
using PetPals_C_.Repository.Interface;
using PetPals_C_.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetPals_C_.Service
{
    internal class DogService : IDogService
    {
        readonly IDogRepository _Dogrepository;
        public DogService()
        {
            _Dogrepository = new DogRepository();
        }
        public void PetDetails()
        {
            try
            {

                List<Dog> dog = _Dogrepository.PetDetails();
                foreach(Dog dogs in dog)
                {
                    Console.WriteLine(dogs);
                }
             }  
            catch (Exception ex) { Console.WriteLine(ex.Message); }

        }
    }
}

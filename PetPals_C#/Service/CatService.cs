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
    internal class CatService : ICatService
    {
        readonly ICatRepository _catrepository;
        public CatService()
        {
            _catrepository = new CatRepository();
        }
        public void PetDetails()
        {
            try
            {

                List<Cat> cat = _catrepository.PetDetails();
                foreach (Cat cats in cat)
                {
                    Console.WriteLine(cats);
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }
    }
}

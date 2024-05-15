using PetPals_C_.Service;
using PetPals_C_.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetPals_C_.Pet_Adoption_Platform
{
    internal class PetAdoptionPlatform
    {
        readonly IDogService _dogService;
        readonly ICatService _catService;
        readonly IPetShelterService _petShelterService;
        readonly IAdoptableServices _adoptablesServices;
        public PetAdoptionPlatform()
        {
           _dogService = new DogService();
            _catService = new CatService();
            _petShelterService = new PetShelterService();
            _adoptablesServices = new AdoptableServices();
        }

        public void Run()
        {
            Console.WriteLine("Welcome to Pet Adoption Platform");
            bool sts = true;
            int option;
            int mamoption;
            while (sts) 
            {
                Console.WriteLine("1.Displaying Pet Listings\n2.Donation Recording\n3.Adoption Event Management");
                option =int.Parse(Console.ReadLine());

                switch (option) 
                {
                    case 1:
                        {
                            Console.WriteLine("Pet details");
                            _dogService.PetDetails();
                            _catService.PetDetails();
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Adoption Event Management:");
                            Console.WriteLine("1.ListAvailablePets\n2.AddPet\n3.RemovePet\n4.HostEvent");
                            mamoption =int.Parse(Console.ReadLine());
                            switch (mamoption)
                            {
                                case 1: { _petShelterService.ListAvailablePets(); break; }
                                case 2: { _petShelterService.AddPet(); break; }
                                case 3: { _petShelterService.RemovePet(); break; }
                                case 4: { _adoptablesServices.HostEvent();break; }
                            }

                            break;

                        }


                }

            }
           
        }
    }
}

using PetPals_C_.Model;
using PetPals_C_.Repository;
using PetPals_C_.Repository.Interface;
using PetPals_C_.Service.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetPals_C_.Service
{
    internal class AdoptableServices : IAdoptableServices
    {
        IAdoptableRepository _adoptablerepository;
        public AdoptableServices()
        {
            _adoptablerepository = new AdoptableRepository();
        }
        public void HostEvent()
        {
            try
            {
                AdoptionEvents eve = new AdoptionEvents();
                Console.WriteLine("Event Hosting");
                Console.WriteLine("Event name ");
                eve.EventName = Console.ReadLine();
                Console.WriteLine("Event date");
                eve.EventDate=DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Enter location");
                eve.Location = Console.ReadLine();
                int sts = _adoptablerepository.HostEvent(eve);
                if (sts > 0)
                {
                    Console.WriteLine("Event Registed for hosting");
                }
                else
                {
                    Console.WriteLine("Event could'n  Registe");
                   
                }

            } catch { }
        }
    }
}

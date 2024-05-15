using PetPals_C_.Exceptions;
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
    internal class PetShelterService : IPetShelterService
    {
        readonly IPetShelterRepository _petshelterrepository;
        public PetShelterService()
        {
            _petshelterrepository = new PetShelterRepository();
        }

        public void AddPet()
        {
            try
            {
                Pet pet = new Pet();
                Console.WriteLine("Add pet For Adoptation");
                Console.WriteLine("Enter Pet Name");
                pet.Name = Console.ReadLine();
                Console.WriteLine("Enter Age");
                pet.Age = int.Parse(Console.ReadLine());
                if(pet.Age <= 0) { throw new InvalidPetAgeHandling("Pet age must be possitive"); }
                Console.WriteLine("Breed");
                pet.Breed = Console.ReadLine();
                Console.WriteLine("Type egDog or Cat");
                pet.Type = Console.ReadLine();
                int status = _petshelterrepository.AddPet(pet);
                if (status > 0)
                {
                    Console.WriteLine("Added Sucessfully");
                }
                else
                {
                    Console.WriteLine("Could not Add");
                }
            }
            catch (InvalidPetAgeHandling ex1) { Console.WriteLine(ex1.Message); }
             catch (Exception ex) { Console.WriteLine(ex.Message); }





        }

        public void ListAvailablePets()
        {
            try
            {

                List<Pet> pet = _petshelterrepository.ListAvailablePets();
                foreach (Pet pets in pet)
                {
                    Console.WriteLine($"pet id ::{pets.PetId}\tPet Name ::" +
                        $"{pets.Name}\tAge::{pets.Age}\tBreed::{pets.Breed}\ttype::{pets.Type}");
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }

        public void RemovePet()
        {
            try
            {


                Console.WriteLine("Remove pet from Adoptation ");
                Console.WriteLine("Enter Petid");
                int petid = int.Parse(Console.ReadLine());
                int sts = _petshelterrepository.RemovePet(petid);
                if (sts > 0)
                {
                    Console.WriteLine("Removed Sucessfully");
                }
                else
                {
                    Console.WriteLine("Could not remove");
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }
    }
}

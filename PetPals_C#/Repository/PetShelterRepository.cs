using PetPals_C_.Model;
using PetPals_C_.Repository.Interface;
using PetPals_C_.Utility;
using System.Data.SqlClient;
using System.Net;
using System.Numerics;
using System.Xml.Linq;

namespace PetPals_C_.Repository
{
    internal class PetShelterRepository : IPetShelterRepository
    {

        SqlConnection sqlConnection = null;
        SqlCommand cmd = null;

        public PetShelterRepository()
        {
            sqlConnection = new SqlConnection(DBConnUtil.GetConnectionString());
            cmd = new SqlCommand();
        }

        public int AddPet(Pet pet)
        {
            int result = 0;
            try
            {
                cmd.Parameters.Clear();
                cmd.CommandText = "insert into Pets values(@name,@age,@breed,@type,null,null,1)";      
                cmd.Parameters.AddWithValue("@name", pet.Name);
                cmd.Parameters.AddWithValue("@age", pet.Age);
                cmd.Parameters.AddWithValue("@breed", pet.Breed);
                cmd.Parameters.AddWithValue("@type", pet.Type);
                cmd.Connection = sqlConnection;
                sqlConnection.Open();
                 result = cmd.ExecuteNonQuery();
                sqlConnection.Close();
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            return result;
           
        }

        public List<Pet> ListAvailablePets()
        {
            List<Pet> petList = new List<Pet>();
            try
            {
                cmd.Parameters.Clear();
                cmd.CommandText = "select * from Pets where AvailableForAdoption=1 ";
                cmd.Connection = sqlConnection;
                sqlConnection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Pet pet = new Pet();
                    pet.PetId = (int)reader["PetID"];
                    pet.Name = (string)reader["Name"];
                    pet.Age = (int)reader["Age"];
                    pet.Breed = (string)reader["Breed"];
                    pet.Type = (string)reader["Type"];
                   

                    petList.Add(pet);
                }
                sqlConnection.Close();
            }catch (Exception ex) { Console.WriteLine(ex.Message); }
            return petList;
        }

        public int RemovePet(int petid)
        {
            int result=0;
            try
            {
                cmd.CommandText = "update pets set AvailableForAdoption=0 where petid=@id";
                cmd.Parameters.AddWithValue("@id", petid);
                cmd.Connection = sqlConnection;
                sqlConnection.Open();
                result= cmd.ExecuteNonQuery();
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            return result;
        }
    }
}

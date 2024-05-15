using PetPals_C_.Model;
using PetPals_C_.Repository.Interface;
using PetPals_C_.Utility;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetPals_C_.Repository
{
    internal class DogRepository : IDogRepository
    {
        SqlConnection sqlConnection = null;
        SqlCommand cmd = null;
        public DogRepository()
        {
            sqlConnection = new SqlConnection(DBConnUtil.GetConnectionString());
            cmd = new SqlCommand();
        }
        public List<Dog> PetDetails()
        {
            List<Dog> dogList = new List<Dog>();
            try
            {


               cmd.Parameters.Clear();

                cmd.CommandText = "select * from Pets where Type='Dog'";
                cmd.Connection = sqlConnection;
                sqlConnection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Dog dog = new Dog();
                    dog.PetId = (int)reader["PetID"];
                    dog.Name = (string)reader["Name"];
                    dog.Age = (int)reader["Age"];
                    dog.Breed = (string)reader["Breed"];
                    dog.DogBreed = (string)reader["Breed"];
                   
                    dogList.Add(dog);
                }
                sqlConnection.Close();
            }catch (Exception ex) { Console.WriteLine(ex.Message); }
            return dogList;
        }
    }
}

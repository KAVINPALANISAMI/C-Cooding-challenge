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
    internal class CatRepository : ICatRepository
    {
        SqlConnection sqlConnection = null;
        SqlCommand cmd = null;
        public CatRepository()
        {
            sqlConnection = new SqlConnection(DBConnUtil.GetConnectionString());
            cmd = new SqlCommand();
        }
        public List<Cat> PetDetails()
        {
            List<Cat> catList = new List<Cat>();
            try
            {


                cmd.Parameters.Clear();

                cmd.CommandText = "select * from Pets where Type='Cat'";
                cmd.Connection = sqlConnection;
                sqlConnection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Cat dog = new Cat();
                    dog.PetId = (int)reader["PetID"];
                    dog.Name = (string)reader["Name"];
                    dog.Age = (int)reader["Age"];
                    dog.Breed = (string)reader["Breed"];
                    dog.CatColor = (string)reader["colour"];

                    catList.Add(dog);
                }
                sqlConnection.Close();
            }catch (Exception ex) { Console.WriteLine(ex.Message); }
            return catList;
        }
    }
}

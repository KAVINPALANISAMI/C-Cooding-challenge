using PetPals_C_.Model;
using PetPals_C_.Repository.Interface;
using PetPals_C_.Utility;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PetPals_C_.Repository
{
    internal class AdoptableRepository : IAdoptableRepository
    {
        SqlConnection sqlConnection = null;
        SqlCommand cmd = null;
        public AdoptableRepository()
        {
            sqlConnection = new SqlConnection(DBConnUtil.GetConnectionString());
            cmd = new SqlCommand();
        }
        public int HostEvent(AdoptionEvents eve)
        {
            int result = 0;
            try
            { cmd.Parameters.Clear();
                cmd.CommandText = "insert into AdoptionEvents values(@name,@date,@location)";
                cmd.Parameters.AddWithValue("@name", eve.EventName);
                cmd.Parameters.AddWithValue("@date", eve.EventDate);
                cmd.Parameters.AddWithValue("@location", eve.Location);
                cmd.Connection = sqlConnection;
                sqlConnection.Open();
                result = cmd.ExecuteNonQuery();
                sqlConnection.Close();
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            return result;
        }
    }
}

using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace PetPals_C_.Utility
{
    internal class DBConnUtil
    {
        private static IConfiguration _iconfiguration;
        public DBConnUtil()
        {
            GetAppSettingsFile();
        }
        private static void GetAppSettingsFile()
        {
            var builder = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json");
            _iconfiguration = builder.Build();

        }

        public static string GetConnectionString()
        {
            // return _iconfiguration.GetConnectionString("LocalConnectionString");
            return "Server = KING; Database = PetPals; Trusted_Connection = True";
        }

    }
}

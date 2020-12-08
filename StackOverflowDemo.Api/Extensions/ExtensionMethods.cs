using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StackOverflowDemo.Api.Extensions
{
    public static class ExtensionMethods
    {
        public static string  GetConnectionStringUsingSecrets(this IConfiguration config, string connectionStringName, bool trusted = true)
        {
            string connectionString = config.GetConnectionString(connectionStringName);
            var secrets = config.GetSection(connectionStringName);
            string server = $"Server={secrets["Server"]};";
            if (trusted)
            {
                return server + connectionString;
            }
            string user = $"UserId={secrets["User"]};";
            string password = $"Password={secrets["Password"]}";
            return server + user + password + connectionString;
        }
    }
}

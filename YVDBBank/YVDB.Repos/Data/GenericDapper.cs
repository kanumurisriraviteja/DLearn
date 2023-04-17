using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YVDB.Repos.Data
{
    public class GenericDapper<T>
    {
        private readonly string connectionString;
        public GenericDapper()
        {
            //ConfigurationManager.AppSettings["csmssql"] ??
            connectionString =  @"Server=KANUMURITEJA\SQLEXPRESS;Database=DLearn;Integrated Security=True;Trusted_Connection=True;TrustServerCertificate=True";
        }
        public async Task<IEnumerable<T>> SQLQueryAsync(string query)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                var customers = await connection.QueryAsync<T>(query);
                return customers;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace products
{
    public class CreamRepository
    {
        DbProviderFactory factory;
        string provider;
        string connectionString;
        public CreamRepository()
        {
            provider = ConfigurationManager.AppSettings["provider"];
            connectionString = ConfigurationManager.AppSettings["connectionString"];
            factory = DbProviderFactories.GetFactory(provider);
        }
        public List<Cream> GetAll()
        {
            var creams = new List<Cream>();
            using (var connection = factory.CreateConnection())
            {
                connection.ConnectionString = connectionString;
                connection.Open();
                var command = factory.CreateCommand();
                command.Connection = connection;
                command.CommandText = "Select * From Creams;";
                using (DbDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        creams.Add(new Cream
                        {
                            id = (string)reader["id"],
                            name = (string)reader["name"],
                            price = (decimal)reader["price"],
                            type = (string)reader["type"]
                        });
                    }
                }
            }
            return creams;
        }
    }
}

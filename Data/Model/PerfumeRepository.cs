using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace products
{
    public class PerfumeRepository
    {
        DbProviderFactory factory;
        string provider;
        string connectionString;
        public PerfumeRepository()
        {
            provider = ConfigurationManager.AppSettings["provider"];
            connectionString = ConfigurationManager.AppSettings["connectionString"];
            factory = DbProviderFactories.GetFactory(provider);
        }
        public List<Perfume> GetAll()
        {
            var perfumes = new List<Perfume>();
            using (var connection = factory.CreateConnection())
            {
                connection.ConnectionString = connectionString;
                connection.Open();
                var command = factory.CreateCommand();
                command.Connection = connection;
                command.CommandText = "Select * From Perfumes;";
                using (DbDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        perfumes.Add(new Perfume
                        {
                            id = (string)reader["id"],
                            name = (string)reader["name"],
                            price = (decimal)reader["price"],
                            type = (string)reader["type"]
                        });
                    }
                }
            }
            return perfumes;
        }
    }
}

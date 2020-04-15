using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace products
{
    public class MakeUpRepository
    {
        DbProviderFactory factory;
        string provider;
        string connectionString;
        public MakeUpRepository()
        {
            provider = ConfigurationManager.AppSettings["provider"];
            connectionString = ConfigurationManager.AppSettings["connectionString"];
            factory = DbProviderFactories.GetFactory(provider);
        }
        public List<MakeUp> GetAll()
        {
            var makeUps = new List<MakeUp>();
            using (var connection = factory.CreateConnection())
            {
                connection.ConnectionString = connectionString;
                connection.Open();
                var command = factory.CreateCommand();
                command.Connection = connection;
                command.CommandText = "Select * From MakeUp;";
                using (DbDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        makeUps.Add(new MakeUp
                        {
                            id = (string)reader["id"],
                            name = (string)reader["name"],
                            price = (decimal)reader["price"],
                            type = (string)reader["type"]
                        });
                    }
                }
            }
            return makeUps;
        }
    }
}

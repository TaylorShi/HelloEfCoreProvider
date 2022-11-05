using System;
using System.Data.SqlClient;
using System.Linq;

namespace TeslaOrder.ConnectionStringConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var connectionString = "Server=tcp:127.0.0.1,5433;Database=Microsoft.eShopOnContainers.Services.OrderingDb;User Id=sa;Password=Pass@word;";
            SqlConnectionStringBuilder builder =  new SqlConnectionStringBuilder(connectionString);
            var properties = builder.GetType().GetProperties();
            foreach (var property in properties)
            {
                if (property.CanRead)
                {
                    if (property.GetIndexParameters().Length == 0)
                    {
                        Console.WriteLine($"{property.Name}:{property.GetValue(builder) ?? ""}");
                    }
                }
            }
            Console.ReadKey();
        }
    }
}

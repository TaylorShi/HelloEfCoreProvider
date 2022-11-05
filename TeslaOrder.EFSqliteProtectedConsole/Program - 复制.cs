using Microsoft.Data.Sqlite;
using System;

namespace TeslaOrder.EFSqliteProtectedConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var folder = Environment.SpecialFolder.MyDocuments;
            var path = Environment.GetFolderPath(folder);
            var dbPath = System.IO.Path.Join(path, "blog.db");
            var baseConnectionString = $"Data Source={dbPath}";

            var oldPassword = "BkBqwG3ps25qQExj";
            var connectionString = new SqliteConnectionStringBuilder(baseConnectionString)
            {
                Mode = SqliteOpenMode.ReadWriteCreate,
                Password = oldPassword
            }.ToString();

            // 设置密码
            using (SqliteConnection connection = new SqliteConnection(connectionString))
            {
                connection.Open();

                using (var cmd = connection.CreateCommand())
                {
                    cmd.CommandText = @"CREATE TABLE Users (
                        ID INTEGER PRIMARY KEY AUTOINCREMENT
                    );";
                    cmd.ExecuteNonQuery();
                }
            }
            Console.ReadKey();
        }
    }
}

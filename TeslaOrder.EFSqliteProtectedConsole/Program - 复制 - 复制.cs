using Microsoft.Data.Sqlite;
using System;

namespace TeslaOrder.EFSqliteProtectedConsole
{
    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        var folder = Environment.SpecialFolder.MyDocuments;
    //        var path = Environment.GetFolderPath(folder);
    //        var dbPath = System.IO.Path.Join(path, "postting.db");
    //        var baseConnectionString = $"Data Source={dbPath}";

    //        var oldPassword = "BkBqwG3ps25qQExj";
    //        var connectionString = new SqliteConnectionStringBuilder(baseConnectionString)
    //        {
    //            Mode = SqliteOpenMode.ReadWriteCreate,
    //            Password = oldPassword
    //        }.ToString();

    //        // 修改密码
    //        var newPassword = "BkBqwG3ps25qQEx";
    //        using (SqliteConnection connection = new SqliteConnection(connectionString))
    //        {
    //            connection.Open();

    //            using (var command = connection.CreateCommand())
    //            {
    //                command.CommandText = "SELECT quote($newPassword);";
    //                command.Parameters.AddWithValue("$newPassword", newPassword);
    //                var quotedNewPassword = command.ExecuteScalar() as string;

    //                command.CommandText = "PRAGMA rekey = " + quotedNewPassword;
    //                command.Parameters.Clear();
    //                command.ExecuteNonQuery();
    //            }
    //        }
    //        Console.ReadKey();
    //    }
    //}
}

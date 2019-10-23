using System;
using System.Data.SqlClient;

namespace ado.net_hw_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Server=DESKTOP-RM1NBDJ;Database=temp;Trusted_Connection=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand sqlCommand = connection.CreateCommand())
            {
                connection.Open();
                string query = "CREATE TABLE [Group] ( id int not null, name nvarchar(max))";
                sqlCommand.CommandText = query;
                sqlCommand.ExecuteNonQuery();
            }
        }
    }
}

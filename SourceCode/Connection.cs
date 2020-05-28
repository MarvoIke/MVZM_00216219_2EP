using System.Data;
using Npgsql;

namespace parcialDos
{
    public class Connection
    {
        private static string CadenaConexion =
            "Server=localhost;Port=5432;User Id=postgres;Password=marcoV;Database=parcial_2";

        public static DataTable ExecuteQuery(string query)
        {
            NpgsqlConnection connection = new NpgsqlConnection(CadenaConexion);
            DataSet dts = new DataSet();
            
            connection.Open();
            NpgsqlDataAdapter dap = new NpgsqlDataAdapter(query, connection);
            dap.Fill(dts);
            connection.Close();

            return dts.Tables[0];
        }
        
        public static void ExecuteNonQuery(string act)
        {
            NpgsqlConnection connection = new NpgsqlConnection(CadenaConexion);
            
            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand(act, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
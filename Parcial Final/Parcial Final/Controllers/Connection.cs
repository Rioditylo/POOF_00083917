using System.Data;
using Npgsql;

namespace FinalParcial.ClaseBD
{
    public class Connection
    {
        private static string KeyString = @"
          Host=127.0.0.1;
          Port=5432;
          Username=postgres;
          Password=uca;
          Database=parcial;
        ";
        public static DataTable Query(string sql)
        {
            NpgsqlConnection conn = new NpgsqlConnection(KeyString);
            DataSet ds = new DataSet();
            
            conn.Open();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, conn);
            da.Fill(ds);
            conn.Close();
            
            return ds.Tables[0];
        }

        public static void NoQuery(string sql)
        {
            NpgsqlConnection conn = new NpgsqlConnection(KeyString);
            
            conn.Open();
            NpgsqlCommand nc = new NpgsqlCommand(sql, conn);
            nc.ExecuteNonQuery();
            conn.Close();
        }
    }
}
using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Otobilet
{
    internal class Fonksiyonlar
    {
        SqlConnection Con;
        SqlDataAdapter Sda;
        DataTable dt;
        SqlCommand cmd;
        string ConStr;

        public Fonksiyonlar()
        {
            ConStr = @"Data Source=DESKTOP-LDVGBVA\SQLEXPRESS;Initial Catalog=OtobiletDb;Integrated Security=True;";
            Con = new SqlConnection(ConStr);
            cmd = new SqlCommand();
            cmd.Connection = Con;
        }

        // Sql bağlantısını kapatma
        public DataTable GetData(string Query)
        {
            using (SqlConnection con = new SqlConnection(ConStr))
            {
                using (SqlDataAdapter sda = new SqlDataAdapter(Query, con))
                {
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    return dt;
                }
            }
        }

        public int setData(string Query)
        {
            int Cnt = 0;
            if (Con.State == ConnectionState.Closed)
            {
                Con.Open();
            }
            cmd.CommandText = Query;
            Cnt = cmd.ExecuteNonQuery();
            Con.Close();
            return Cnt;

        }
        public void ExecuteQuery(string query)
        {
            using (SqlConnection con = new SqlConnection(ConStr))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.ExecuteNonQuery();
                }
                // using bloğu dışında SQL bağlantısı otomatik olarak kapanır.
            }
        }
    }
}

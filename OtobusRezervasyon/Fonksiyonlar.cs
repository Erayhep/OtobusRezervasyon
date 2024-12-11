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
        private readonly string connectionString;
        SqlConnection Con;
        SqlDataAdapter Sda;
        DataTable dt;
        SqlCommand cmd;
        string ConStr;

        public Fonksiyonlar()
        {
            connectionString = @"Data Source=DESKTOP-LDVGBVA\SQLEXPRESS;Initial Catalog=OtobiletDb;Integrated Security=True;";
            ConStr = @"Data Source=DESKTOP-LDVGBVA\SQLEXPRESS;Initial Catalog=OtobiletDb;Integrated Security=True;";
            Con = new SqlConnection(ConStr);
            cmd = new SqlCommand();
            cmd.Connection = Con;
        }

        private SqlConnection GetConnection()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            return conn;
        }

        // Veri çekme metodu
        public DataTable GetData(string query, SqlParameter[] parameters = null)
        {
            using (SqlConnection con = new SqlConnection(ConStr))
            {
                using (SqlDataAdapter sda = new SqlDataAdapter(query, con))
                {
                    if (parameters != null)
                    {
                        sda.SelectCommand.Parameters.AddRange(parameters);  // Parametreleri ekliyoruz
                    }

                    DataTable dt = new DataTable();
                    sda.Fill(dt);  // Veriyi alıyoruz
                    return dt;
                }
            }
        }

        // Veri ekleme/güncelleme/silme metodu
        public int setData(string query, SqlParameter[] parameters = null)
        {
            int Cnt = 0;
            using (SqlConnection con = new SqlConnection(ConStr))
            {
                SqlCommand cmd = new SqlCommand(query, con);

                // Parametre ekleme
                if (parameters != null)
                {
                    cmd.Parameters.AddRange(parameters);  // Parametreleri ekliyoruz
                }

                con.Open();
                Cnt = cmd.ExecuteNonQuery();  // ExecuteNonQuery, SQL sorgusunun etkilenen satır sayısını döndürür
                con.Close();
            }
            return Cnt;
        }

        // SQL sorgusu çalıştırma
        public void ExecuteQuery(string query)
        {
            using (SqlConnection con = new SqlConnection(ConStr))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }


    }
}

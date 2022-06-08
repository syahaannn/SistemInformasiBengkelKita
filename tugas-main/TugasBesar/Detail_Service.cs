using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasBesar
{
    public class Detail_Service
    {
        protected static String conString = ConfigurationManager.ConnectionStrings["inventaris"].ConnectionString;
        static MySqlConnection conn;
        static MySqlCommand cmd;

        public String id_service { set; get; }
        public DateTime tgl_service { set; get; }
        public int total_biaya { set; get; }
        public String nama_service { set; get; }
        public int biaya { set; get; }
        public Detail_Service()
        {
            conn = new MySqlConnection(conString);
            cmd = new MySqlCommand();
        }

        public static DataTable Select(String id)
        {
            conn = new MySqlConnection(conString);
            DataTable dt = new DataTable();
            cmd = conn.CreateCommand();
            if (id != "")
            {
                cmd.CommandText = "SELECT id_service, tgl_service, total_biaya FROM service " +
                    "WHERE id_service = @id_service";
                cmd.Parameters.AddWithValue("@id_service", id);
            }
            else { return null; }
            try
            {
                conn.Open();
                MySqlDataReader rdr = cmd.ExecuteReader();
                dt.Load(rdr);
                conn.Close();
            }
            catch (Exception ex)
            {
                String error = ex.Message;
            }
            return dt;
        }

        public static DataTable SelectSUM(String tgl_awal, String tgl_akhir)
        {
            conn = new MySqlConnection(conString);
            DataTable dt = new DataTable();
            cmd = conn.CreateCommand();
            if (tgl_awal != "" && tgl_akhir != "")
            {
                cmd.CommandText = "SELECT id_service, total_biaya FROM service " +
                    "WHERE (tgl_service BETWEEN @tgl_awal AND @tgl_akhir)";
                cmd.Parameters.AddWithValue("@tgl_awal", tgl_awal);
                cmd.Parameters.AddWithValue("@tgl_akhir", tgl_akhir);
            }
            else { return null; }
            try
            {
                conn.Open();
                MySqlDataReader rdr = cmd.ExecuteReader();
                dt.Load(rdr);
                conn.Close();
            }
            catch (Exception ex)
            {
                String error = ex.Message;
            }
            return dt;
        }

        public static DataTable SelectDetail(String id)
        {
            conn = new MySqlConnection(conString);
            DataTable dt = new DataTable();
            cmd = conn.CreateCommand();
            if (id != "")
            {
                cmd.CommandText = "SELECT id_service, nama_service, biaya " +
                    "FROM daftar_service WHERE id_service = @id_service";
                cmd.Parameters.AddWithValue("@id_service", id);
            }
            else { return null; }
            try
            {
                conn.Open();
                MySqlDataReader rdr = cmd.ExecuteReader();
                dt.Load(rdr);
                conn.Close();
            }
            catch (Exception ex)
            {
                String error = ex.Message;
            }
            return dt;
        }
    }
}

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
    public class Detail_Transaksi
    {
        protected static String conString = ConfigurationManager.ConnectionStrings["inventaris"].ConnectionString;
        static MySqlConnection conn;
        static MySqlCommand cmd;

        public String id_transaksi { set; get; }
        public DateTime tgl_jual { set; get; }
        public int total { set; get; }
        public String kode_barang { set; get; }
        public String nama_barang { set; get; }
        public int kuantitas_beli { set; get; }
        public int harga_satuan { set; get; }
        public int harga_total { set; get; }

        public Detail_Transaksi()
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
                cmd.CommandText = "SELECT id_transaksi, tgl_jual, total FROM penjualan " +
                    "WHERE id_transaksi = @id_transaksi";
                cmd.Parameters.AddWithValue("@id_transaksi", id);
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
                cmd.CommandText = "SELECT id_transaksi, total FROM penjualan " +
                    "WHERE (tgl_jual BETWEEN @tgl_awal AND @tgl_akhir)";
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
                cmd.CommandText = "SELECT id_transaksi, kode_barang, nama_barang, harga_satuan, kuantitas_beli, harga_total " +
                    "FROM daftar_transaksi WHERE id_transaksi = @id_transaksi";
                cmd.Parameters.AddWithValue("@id_transaksi", id);
            }
            else { return null; }
            try
            {
                conn.Open();
                MySqlDataReader rdr = cmd.ExecuteReader();
                dt.Load(rdr);
                conn.Close();
            }
            catch(Exception ex)
            {
                String error = ex.Message;
            }
            return dt;
        }
    }
}

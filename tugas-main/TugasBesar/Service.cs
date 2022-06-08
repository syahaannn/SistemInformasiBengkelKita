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
    class Service
    {
        protected static String conString = ConfigurationManager.ConnectionStrings["inventaris"].ConnectionString;
        static MySqlConnection conn;
        static MySqlCommand cmd;

        public String id_service { set; get; }
        public String tgl_service { set; get; }
        public int total_biaya { set; get; }
        public String nama_service { set; get; }
        public int biaya { set; get; }
        public String struk { set; get; }
        public String tgl_awal { set; get; }
        public String tgl_akhir { set; get; }

        public Service()
        {
            conn = new MySqlConnection(conString);
            cmd = new MySqlCommand();
        }

        public String InsertStruk()
        {
            String error = null;
            conn.Open();
            cmd = conn.CreateCommand();
            cmd.CommandText = "INSERT INTO daftar_service VALUES (@id_service, @nama_service, @biaya)";
            cmd.Parameters.AddWithValue("@id_service", this.id_service);
            cmd.Parameters.AddWithValue("@nama_service", this.nama_service);
            cmd.Parameters.AddWithValue("@biaya", this.biaya);

            try
            {
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception e)
            {
                error = e.Message;
            }
            return error;
        }

        public String Insert()
        {
            String error = null;
            conn.Open();
            cmd = conn.CreateCommand();
            cmd.CommandText = "INSERT INTO service VALUES (@id_service, @tgl_service, @total_biaya)";
            cmd.Parameters.AddWithValue("@id_service", this.id_service);
            cmd.Parameters.AddWithValue("@tgl_service", this.tgl_service);
            cmd.Parameters.AddWithValue("@total_biaya", this.total_biaya);

            try
            {
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception e)
            {
                error = e.Message;
            }
            return error;
        }

        public DataTable ReadStruk()
        {
            DataTable dt = new DataTable();
            conn.Open();
            cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT nama_service as 'Nama Service', " +
                "biaya as 'Biaya' FROM daftar_service WHERE id_service = '" + struk + "'";
            cmd.Parameters.AddWithValue(struk, this.struk);
            {
                try
                {
                    MySqlDataReader rdr = cmd.ExecuteReader();
                    dt.Load(rdr);
                }
                catch (Exception e) { }
            }
            return dt;
        }

        public DataTable ReadSUM()
        {
            DataTable dt = new DataTable();
            conn.Open();
            cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT id_service as 'ID Service', total_biaya as 'Total Harga' FROM service " +
                "WHERE (tgl_service BETWEEN @tgl_awal AND @tgl_akhir)";
            cmd.Parameters.AddWithValue("@tgl_awal", this.tgl_awal);
            cmd.Parameters.AddWithValue("@tgl_akhir", this.tgl_akhir);
            {
                try
                {
                    MySqlDataReader rdr = cmd.ExecuteReader();
                    dt.Load(rdr);
                }
                catch (Exception e) { }
            }
            return dt;
        }
    }
}

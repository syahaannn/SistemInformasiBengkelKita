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
    public class Pegawai
    {
        protected static String conString = ConfigurationManager.ConnectionStrings["inventaris"].ConnectionString;
        static MySqlConnection conn;
        static MySqlCommand cmd;

        public int id_pegawai { set; get; }
        public String nama_pegawai { set; get; }
        public String tempat_lahir { set; get; }
        public String tanggal_lahir { set; get; }
        public String agama { set; get; }
        public String alamat { set; get; }
        public String username { set; get; }
        public String password { set; get; }
        public int role { set; get; }
        public int id_user { set; get; }

        public Pegawai()
        {
            conn = new MySqlConnection(conString);
            cmd = new MySqlCommand();
        }

        public String Insert()
        {
            String error = null;
            conn.Open();
            cmd = conn.CreateCommand();
            cmd.CommandText = "INSERT INTO data_pegawai (nama_pegawai, tempat_lahir, tanggal_lahir, " +
                "agama, alamat) VALUES (@nama_pegawai, @tempat_lahir, @tanggal_lahir, @agama, @alamat)";
            cmd.Parameters.AddWithValue("@nama_pegawai", this.nama_pegawai);
            cmd.Parameters.AddWithValue("@tempat_lahir", this.tempat_lahir);
            cmd.Parameters.AddWithValue("@tanggal_lahir", this.tanggal_lahir);
            cmd.Parameters.AddWithValue("@agama", this.agama);
            cmd.Parameters.AddWithValue("@alamat", this.alamat);

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

        public String Delete()
        {
            String result = null;
            conn.Open();
            using (MySqlCommand cmd = new MySqlCommand("DELETE FROM data_pegawai WHERE id_pegawai = @id_pegawai", conn))
            {
                cmd.Parameters.AddWithValue("@id_pegawai", this.id_pegawai);
                try
                {
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                catch (Exception e)
                {
                    return e.Message;
                }
            }
            return result;
        }

        public String Update()
        {
            string result = null;
            conn.Open();
            cmd = conn.CreateCommand();
            cmd.CommandText = "UPDATE data_pegawai set nama_pegawai = @nama_pegawai, tempat_lahir = @tempat_lahir, tanggal_lahir = @tanggal_lahir, " +
                "agama = @agama, alamat = @alamat WHERE id_pegawai = @id_pegawai";
            cmd.Parameters.AddWithValue("@nama_pegawai", this.nama_pegawai);
            cmd.Parameters.AddWithValue("@tempat_lahir", this.tempat_lahir);
            cmd.Parameters.AddWithValue("@tanggal_lahir", this.tanggal_lahir);
            cmd.Parameters.AddWithValue("@agama", this.agama);
            cmd.Parameters.AddWithValue("@alamat", this.alamat);
            cmd.Parameters.AddWithValue("@id_pegawai", this.id_pegawai);
            try
            {
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception e)
            {
                return e.Message;
            }
            return result;
        }

        public static Pegawai Select(int id_pegawai)
        {
            Pegawai pegawai = new Pegawai();
            conn.Open();
            cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT a.id_user, a.username, a.password, a.role, p.nama_pegawai FROM akun a INNER JOIN data_pegawai p " +
                "ON p.id_pegawai = a.id_pegawai WHERE p.id_pegawai = @id_pegawai";
            cmd.Parameters.AddWithValue("@id_pegawai", id_pegawai);
            try
            {
                MySqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    rdr.Read();
                    pegawai.id_user = rdr.GetInt32(0);
                    pegawai.username = rdr.GetString(1);
                    pegawai.password = rdr.GetString(2);
                    pegawai.role = rdr.GetInt32(3);
                    pegawai.nama_pegawai = rdr.GetString(4);
                }
            }
            catch (Exception e)
            {
                String eror = e.Message;
            }
            conn.Close();
            return pegawai;
        }
    }
}
